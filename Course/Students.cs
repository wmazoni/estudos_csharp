using System;
using System.Collections.Generic;
using System.Text;

namespace Course {
    class Students {
        public string Name { get; set; }
        public string Email { get; set; }

        public Students(string name, string email) {
            Name = name;
            Email = email;
        }

        public override string ToString() {
            return Name + ", " + Email;
        }
    }
}
