using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCModelBinderBug.Models {
    public class HomeViewModel {

        public ComplexModel Model {
            get;
            set;
        }

        public string SomeOtherProperty {
            get;
            set;
        }

        public int MoreProperty {
            get;
            set;
        }
    }
}