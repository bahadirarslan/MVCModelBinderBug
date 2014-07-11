using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCModelBinderBug.Models {
    public class FormPostViewModel {
        public string Name {
            get;
            set;
        }
        public string SomeOtherProperty {
            get;
            set;
        }
    }
}