//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PAL_PlayAndLearn
{
    using System;
    using System.Collections.Generic;
    
    public partial class Test
    {
        public Test()
        {
            this.TestQuestions = new HashSet<TestQuestion>();
        }
    
        public int ID { get; set; }
        public string TestName { get; set; }
        public int TestSBJNameID { get; set; }
    
        public virtual ICollection<TestQuestion> TestQuestions { get; set; }
        public virtual TestsSubjectsName TestsSubjectsName { get; set; }
    }
}
