using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class HumanModelUnitTest
    {
        [Test]
        public void Model_Properties_Is_Not_Null_After_Init()
        { 
            Human human = new Human();

            Assert.IsNotNull(human.Name, "Имя не должно быть неназначенным");
            Assert.IsNotEmpty(human.Name, "Имя не должно быть пустым");
            Assert.Greater(human.Birthday, DateTime.MinValue, "Дата должна быть указана");
        }
    }
}
