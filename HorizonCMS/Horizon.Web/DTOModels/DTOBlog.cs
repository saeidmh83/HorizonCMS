﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Horizon.Web.DTOModels
{
    public class DTOBlog
    {

        public Guid Id { get; set; }


        public string Name { get; set; }

        public string Description { get; set; }


        public string Title { get; set; }

        public bool IsActive { get; set; }

    }
}