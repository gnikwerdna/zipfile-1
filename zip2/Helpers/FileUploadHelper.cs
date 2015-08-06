﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zip2.Helpers
{
    public static class FileUploadHelper
    {
        public static bool HasFile(this HttpPostedFileBase file)
        {
            return (file != null && file.ContentLength > 0) ? true : false;
        }

    }
}