using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepintoCsharp
{
    /*
     * 索引器（Indexer）是一种特殊类型的成员，允许您通过类的实例像访问数组一样访问对象的元素。索引器允许您定义类似于属性的语法，但是可以使用索引来访问类的元素，而不仅仅是通过属性名来访问。
     */
    class Student
    {
        //使用于集合
        private Dictionary<string, int> score = new Dictionary<string, int>();

        public int? this[string subject]
        {
            get 
            {
                if (this.score.ContainsKey(subject))
                {
                    return this.score[subject];
                }
                else
                {
                    return null;
                }
            }
            set 
            {
                if (value.HasValue ==false)
                {
                    throw new Exception("score can not null");
                }

                if (this.score.ContainsKey(subject))
                {
                    this.score[subject] = value.Value;
                }
                else
                {
                    this.score.Add(subject, value.Value);
                }
            
            }
        }
    }
}
