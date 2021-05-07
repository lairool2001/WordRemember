using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeDanJi
{
    [Serializable]
    public class QandA
    {
        public string q, a;
        public int wrongCount, correctCount;
        public DateTime newestShowDateTime;
        public override string ToString()
        {
            return "問題:" + q + "," + "答案:" + a;
        }
    }
}
