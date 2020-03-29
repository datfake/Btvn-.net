using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_49
{
    class Question
    {
        private String id;
        private String content;
        private String ques1;
        private String ques2;
        private String ques3;
        private String correct;
        private String time;

        public Question(String id, String content, String ques1, String ques2, String ques3, String correct, String time)
        {
            this.id = id;
            this.content = content;
            this.ques1 = ques1;
            this.ques2 = ques2;
            this.ques3 = ques3;
            this.correct = correct;
            this.time = time;
        }

        public String getId()
        {
            return this.id;
        }

        public void Xuat()
        {
            Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5}", this.id, this.content, this.ques1,
                this.ques2, this.ques3, this.correct,this.time);
        }
    }
}
