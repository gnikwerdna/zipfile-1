using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using zip2.DB;
using zip2.Models;
using zip2.Helpers;
using System.IO;
using System.Configuration;

namespace zip2.Controllers
{
    public class PeopleController : Controller
    {
        private zipContext db = new zipContext();

        // GET: People
        [Audit]
        [Authorize]
        public ActionResult Index()
        {
          
            
            
            return View(db.Persons.ToList());
        }

        // GET: People/Details/5
        [Audit]
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.Persons.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            var associatedfiles = (from p in db.Files where p.PersonId == id select p);
            ViewBag.filelist = associatedfiles.ToList();
            return View(person);
        }
        [Audit]
        [Authorize]
        public ActionResult Uploader()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Audit]
        [Authorize]
        public ActionResult Uploader(int? id)
        {
            foreach (string upload in Request.Files)
            {
                if (!Request.Files[upload].HasFile()) continue;
                int PersonId = 1;
                int FileType = 1;
                string mimeType = Request.Files[upload].ContentType;
                Stream fileStream = Request.Files[upload].InputStream;
                string fileName = Path.GetFileName(Request.Files[upload].FileName);
                int fileLength = Request.Files[upload].ContentLength;
                byte[] fileData = new byte[fileLength];
                fileStream.Read(fileData, 0, fileLength);

                 string connect = ConfigurationManager.ConnectionStrings["cmd"].ToString();
                using (var conn = new SqlConnection(connect))
                {
                    var qry = "INSERT INTO Files (Content, ContentType, FileName,PersonId,FileType) VALUES (@FileContent, @MimeType, @FileName,@PersonId,@FileType)";
                    var cmd = new SqlCommand(qry, conn);
                    cmd.Parameters.AddWithValue("@FileContent", fileData);
                    cmd.Parameters.AddWithValue("@MimeType", mimeType);
                    cmd.Parameters.AddWithValue("@FileName", fileName);
                    cmd.Parameters.AddWithValue("@PersonId", PersonId);
                    cmd.Parameters.AddWithValue("@FileType", FileType);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            return View();


        }
        [Audit]
        [Authorize]
        public FileContentResult GetFile(int id)
        {
            SqlDataReader rdr; byte[] fileContent = null;
            string mimeType = ""; string fileName = "";
             string connect = ConfigurationManager.ConnectionStrings["cmd"].ToString();

            using (var conn = new SqlConnection(connect))
            {
                var qry = "SELECT Content, ContentType, FileName FROM Files WHERE FileId = @ID";
                var cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                conn.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    fileContent = (byte[])rdr["Content"];
                    mimeType = rdr["ContentType"].ToString();
                    fileName = rdr["FileName"].ToString();
                }
            }
            return File(fileContent, mimeType, fileName);
        }


        // GET: People/Create
        [Audit]
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: People/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Audit]
        [Authorize]
        public ActionResult Create([Bind(Include = "PersonId,PName")] Person person)
        {
            if (ModelState.IsValid)
            {
                db.Persons.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(person);
        }

        // GET: People/Edit/5
        [Audit]
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.Persons.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Audit]
        [Authorize]
        public ActionResult Edit([Bind(Include = "PersonId,PName")] Person person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }

        // GET: People/Delete/5
        [Audit]
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.Persons.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Audit]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            Person person = db.Persons.Find(id);
            db.Persons.Remove(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
