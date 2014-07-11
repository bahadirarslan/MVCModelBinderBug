using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCModelBinderBug.Models {
    public class ComplexModel {
        public int ID {
            get;
            set;
        }

        public string Name {
            get;
            set;
        }

        public bool isTest {
            get;
            set;
        }
    }
}