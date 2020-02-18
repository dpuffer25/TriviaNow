using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaNow
{
    class Report
    {
        private BindingList<Question> question = new BindingList<Question>();

        public BindingList<Question> Question { get; set; }

    }
}
