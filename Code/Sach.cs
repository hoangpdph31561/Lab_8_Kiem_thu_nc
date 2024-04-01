namespace Code
{
    public class Sach
    {
        private string id;
        private string ten;
        private int soTrang;
        private string tenTacGia;
        private int lanTaiBan;
        public Sach()
        {

        }

        public Sach(string id, string ten, int soTrang, string tenTacGia, int lanTaiBan)
        {
            this.id = id;
            this.ten = ten;
            this.soTrang = soTrang;
            this.tenTacGia = tenTacGia;
            this.lanTaiBan = lanTaiBan;
        }

        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public int SoTrang { get => soTrang; set => soTrang = value; }
        public string TenTacGia { get => tenTacGia; set => tenTacGia = value; }
        public int LanTaiBan { get => lanTaiBan; set => lanTaiBan = value; }

    }
}
