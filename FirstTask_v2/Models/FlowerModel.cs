using System.Collections;

namespace FirstTask_v2.Models
{
    public class FlowerModel:IEnumerable
    {
        public string[] FlowerList = { "Tulip", "Daffodil", "Poppy", "Snowdrop", "BlueBell", "Rose" };

        public IEnumerator GetEnumerator()
        {
            return FlowerList.GetEnumerator();
        }
    }
}
