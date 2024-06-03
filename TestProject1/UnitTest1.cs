namespace TestProject1
{
    public class HumanEditVMTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NonNullHumanPropertyAfterInit()
        {
            HumanEditVM humanVM = new HumanEditVM();


            Assert.IsNotNull(humanVM.Human);
        }

        [Test]
        public void HumanPropertyValuesEqualTo_humanAfterInitWith1Arg()
        { 
            Human _human = new Human {  Name = "����", Birthday = new DateTime(2000, 02, 29)};
            
            HumanEditVM humanVM = new HumanEditVM(_human);

            Assert.AreEqual(_human.Name, humanVM.Human.Name, "VM ������ ����������� ��� �������������� ������������ � �������� Human");
            Assert.AreEqual(_human.Birthday, humanVM.Human.Birthday, "VM ������ ����������� ���� �������� �������������� ������������ � �������� Human");
        }

        [Test]
        public void HumanPropertyNotSameTo_humanAfterInitWith1Arg()
        {
            Human _human = new Human { Name = "����", Birthday = new DateTime(2000, 02, 29) };

            HumanEditVM humanVM = new HumanEditVM(_human);

            Assert.That(humanVM.Human, Is.Not.SameAs(_human), "������ �� �������� Human �� ������ ��������� ������ ����������� ������� ��� ��������������");
        }
    }
}