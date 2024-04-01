using Code;

namespace Test
{
    public class TestSachService
    {
        SachService sachService;
        [SetUp]
        public void Setup()
        {
            sachService = new SachService();
        }
        [Test]
        public void TestAddSach()
        {
            Sach sach = new Sach("4", "Sach dep", 400, "Tac gia 4", 4);
            Assert.IsTrue(sachService.AddSach(sach));
        }
        [Test]
        public void TestAddSachWithExistedId()
        {
            Sach sach = new Sach("1", "Sach 4", 400, "Tac gia 4", 4);
            Assert.IsFalse(sachService.AddSach(sach));
        }
        [Test]
        public void TestAddSachWithSpecialCharecter()
        {
            Sach sach = new Sach("10", "Sach @", 400, "Tac gia 10", 10);
            Assert.IsFalse(sachService.AddSach(sach));
        }
        [Test]
        public void TestAddSachWithEmptyName()
        {
            Sach sach = new Sach("10", "", 400, "Tac gia 10", 10);
            Assert.IsFalse(sachService.AddSach(sach));
        }
        [Test]
        public void TestAddSachWithFullSpecialCharacterName()
        {
            Sach sach = new Sach("10", "@@@", 400, "Tac gia 10", 10);
            Assert.IsFalse(sachService.AddSach(sach));
        }
        [Test]
        public void TestGetSachByAuthorName()
        {
            IEnumerable<Sach> sachs = sachService.GetSachByAuthorName("Tac gia 1");
            Assert.AreEqual(1, sachs.Count());
        }
        [Test]
        public void TestGetSachByAuthorNameWithNoResult()
        {
            IEnumerable<Sach> sachs = sachService.GetSachByAuthorName("Tac gia 4");
            Assert.AreEqual(0, sachs.Count());
        }
        [Test]
        public void TestGetSachByAuthorNameWithSpecialCharacter()
        {
            IEnumerable<Sach> sachs = sachService.GetSachByAuthorName("Tac gia @");
            Assert.AreEqual(0, sachs.Count());
        }
        [Test]
        public void TestGetSachByAuthorNameWithEmptyString()
        {
            IEnumerable<Sach> sachs = sachService.GetSachByAuthorName("");
            Assert.AreEqual(3, sachs.Count());
        }
        [Test]
        public void TestGetSachByAuthorNameWithFullSpecialCharacter()
        {
            IEnumerable<Sach> sachs = sachService.GetSachByAuthorName("@@@");
            Assert.AreEqual(0, sachs.Count());
        }
        [Test]
        public void TestGetSachByAuthorNameWithNumber()
        {
            IEnumerable<Sach> sachs = sachService.GetSachByAuthorName("Tac gia 1");
            Assert.AreEqual(1, sachs.Count());
        }
    }
}
