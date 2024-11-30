using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace MongoDB_demo
{
    public partial class Form1 : Form
    {
        private MongoClient client;
        private IMongoDatabase database;
        public Form1()
        {
            InitializeComponent();
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("BanVeMayBay");

            btnLoadKhach.Click += btnLoadKhach_Click;
            btnLoadChuyenBay.Click += btnLoadChuyenBay_Click;
            btnLoadVe.Click += btnLoadVe_Click;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLoadKhach_Click(object sender, EventArgs e)
        {
            var khachCollection = database.GetCollection<BsonDocument>("KHACH");
            var khachList = khachCollection.Find(new BsonDocument()).ToList();

            // Chuyển đổi từ BsonDocument sang danh sách các đối tượng Khach
            var khachObjects = khachList.Select(bsonDoc => BsonSerializer.Deserialize<Khach>(bsonDoc)).ToList();

            dgvKhach.AutoGenerateColumns = true;
            dgvKhach.DataSource = khachObjects;
            dgvKhach.Refresh();
        }

        private void btnLoadChuyenBay_Click(object sender, EventArgs e)
        {
            var chuyenBayCollection = database.GetCollection<BsonDocument>("CHUYENBAY");
            var chuyenBayList = chuyenBayCollection.Find(new BsonDocument()).ToList();

            // Chuyển đổi từ BsonDocument sang danh sách các đối tượng ChuyenBay
            var chuyenBayObjects = chuyenBayList.Select(bsonDoc => BsonSerializer.Deserialize<ChuyenBay>(bsonDoc)).ToList();

            dgvChuyenBay.AutoGenerateColumns = true;
            dgvChuyenBay.DataSource = chuyenBayObjects;
            dgvChuyenBay.Refresh();
        }

        private void btnLoadVe_Click(object sender, EventArgs e)
        {
            var veCollection = database.GetCollection<BsonDocument>("VE");
            var veList = veCollection.Find(new BsonDocument()).ToList();

            // Chuyển đổi từ BsonDocument sang danh sách các đối tượng Ve
            var veObjects = veList.Select(bsonDoc => BsonSerializer.Deserialize<Ve>(bsonDoc)).ToList();

            dgvVe.AutoGenerateColumns = true;
            dgvVe.DataSource = veObjects;
            dgvVe.Refresh();
        }

        private void dgvKhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class ChuyenBay
    {
        public ObjectId Id { get; set; }
        public string DiemDi { get; set; }
        public string DiemDen { get; set; }
        public DateTime NgayDi { get; set; }
        public DateTime NgayDen { get; set; }
    }

    // Lớp đại diện cho collection KHACH
    public class Khach
    {
        public ObjectId Id { get; set; }
        public string SoCCCD { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
    }

    // Lớp đại diện cho collection VE
    public class Ve
    {
        public ObjectId Id { get; set; }
        public ObjectId MaKH { get; set; } // Foreign Key đến KHACH
        public ObjectId MaCB { get; set; } // Foreign Key đến CHUYENBAY
        public string HangVe { get; set; }
    }
}
