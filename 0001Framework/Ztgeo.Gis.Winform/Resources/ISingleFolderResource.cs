﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ztgeo.Gis.Winform.Resources
{
    public interface ISingleFolderResource:IResource
    {
         string FolderPath { get; set; }

    }
}
