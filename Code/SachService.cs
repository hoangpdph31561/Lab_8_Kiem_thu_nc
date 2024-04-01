using System.Text.RegularExpressions;

namespace Code
{
    public class SachService
    {
        List<Sach> lstSachs;
        public SachService()
        {
            lstSachs = new List<Sach>()
            {
                new Sach ("1", "Sach 1", 100, "Tac gia 1", 1),
                new Sach ("2", "Sach 2", 200, "Tac gia 2", 2),
                new Sach ("3", "Sach 3", 300, "Tac gia 3", 3),
            };
        }
        public bool AddSach(Sach sach)
        {
            if (lstSachs.Any(x => x.Id == sach.Id))
            {
                return false;
            }
            else if (!Regex.IsMatch(sach.Ten, @"^[\w\s\d]+$"))
            {
                return false;
            }
            lstSachs.Add(sach);
            return true;
        }
        public IEnumerable<Sach> GetSachByAuthorName(string name)
        {

            IEnumerable<Sach> query = lstSachs.Where(x => x.TenTacGia.Contains(name));
            return query;
        }
    }
}
