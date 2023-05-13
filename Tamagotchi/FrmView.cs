using System.Drawing.Imaging;
using System.Security.AccessControl;

namespace Tamagotchi
{
    public partial class FrmView : Form, IView
    {
        public event EventHandler<ViewUpdatedEventArgs> ViewUpdated = delegate { };

        private Rectangle _buttonEatOriginalRectangle;
        private Rectangle _buttonWalkOriginalRectangle;
        private Rectangle _buttonPetOriginalRectangle;
        private Rectangle _pbxPetOriginalRectangle;
        private Rectangle _tbxOriginalRectangle;
        private Rectangle _originalFormSize;

        internal FrmView()
        {
            InitializeComponent();
        }

        private void FrmView_Load(object sender, EventArgs e)
        {
            _originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            _buttonEatOriginalRectangle = new Rectangle(BtnEat.Location.X, BtnEat.Location.Y, BtnEat.Width, BtnEat.Height);
            _buttonWalkOriginalRectangle = new Rectangle(BtnWalk.Location.X, BtnWalk.Location.Y, BtnWalk.Width, BtnWalk.Height);
            _buttonPetOriginalRectangle = new Rectangle(BtnPet.Location.X, BtnPet.Location.Y, BtnPet.Width, BtnPet.Height);
            _pbxPetOriginalRectangle = new Rectangle(PbxPet.Location.X, PbxPet.Location.Y, PbxPet.Width, PbxPet.Height);
            _tbxOriginalRectangle = new Rectangle(TbxTCharacteristics.Location.X, TbxTCharacteristics.Location.Y, TbxTCharacteristics.Width, TbxTCharacteristics.Height);
        }

        private void ResizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(_originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(_originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void FrmView_Resize(object sender, EventArgs e)
        {
            ResizeControl(_buttonEatOriginalRectangle, BtnEat);
            ResizeControl(_buttonWalkOriginalRectangle, BtnWalk);
            ResizeControl(_buttonPetOriginalRectangle, BtnPet);
            ResizeControl(_pbxPetOriginalRectangle, PbxPet);
            ResizeControl(_tbxOriginalRectangle, TbxTCharacteristics);
        }

        public void Update(Dictionary<string, int> TamagotchiCharacteristics)
        {
            TbxTCharacteristics.Text = "";
            TbxTCharacteristics.Text += $"Здоровье питомца: {TamagotchiCharacteristics["HP"]}\r\n";
            TbxTCharacteristics.Text += $"Голод питомца: {TamagotchiCharacteristics["Hunger"]}\r\n";
            TbxTCharacteristics.Text += $"Шкала счастья питомца заполнена на: {TamagotchiCharacteristics["Happiness"]}\r\n";
            TbxTCharacteristics.Text += $"Энергия питомца: {TamagotchiCharacteristics["Energy"]}";
        }

        public void DieHandler()
        {
            MessageBox.Show("Ваш тамагочи умер -- вы не уделяли ему должного внимания.", "Трагичное уведомление");
            this.Close();
        }

        private void BtnEat_Click(object sender, EventArgs e)
        {
            ViewUpdated.Invoke(this, new ViewUpdatedEventArgs(BtnEat.Text.ToString()));
        }

        private void BtnWalk_Click(object sender, EventArgs e)
        {
            ViewUpdated.Invoke(this, new ViewUpdatedEventArgs(BtnWalk.Text.ToString()));
        }

        private void BtnPet_Click(object sender, EventArgs e)
        {
            ViewUpdated.Invoke(this, new ViewUpdatedEventArgs(BtnPet.Text.ToString()));
        }
    }
}