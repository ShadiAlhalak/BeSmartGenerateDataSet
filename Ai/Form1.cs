namespace Ai
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            FirstCombo.DisplayMember = "Text";
            FirstCombo.ValueMember = "Value";
            SecondCombo.DisplayMember = "Text";
            SecondCombo.ValueMember = "Value";
            thirdCombo.DisplayMember = "Text";
            thirdCombo.ValueMember = "Value";
            fourthCombo.DisplayMember = "Text";
            fourthCombo.ValueMember = "Value";
            fifthCombo.DisplayMember = "Text";
            fifthCombo.ValueMember = "Value";
            var Firstitems = new[] {
                new { Text = "", Value = "0" },
                new { Text = "Performance", Value = "1" },
                new { Text = "Display", Value = "2" },
                new { Text = "Camera", Value = "3" },
                new { Text = "Battary/Charging", Value = "4" },
                new { Text = "Build Quality", Value = "5" }
            };
            var Secitems = new[] {
                new { Text = "", Value = "0" },
                new { Text = "Performance", Value = "1" },
                new { Text = "Display", Value = "2" },
                new { Text = "Camera", Value = "3" },
                new { Text = "Battary/Charging", Value = "4" },
                new { Text = "Build Quality", Value = "5" }
            };
            var ThirdItems = new[] {
                new { Text = "", Value = "0" },
                new { Text = "Performance", Value = "1" },
                new { Text = "Display", Value = "2" },
                new { Text = "Camera", Value = "3" },
                new { Text = "Battary/Charging", Value = "4" },
                new { Text = "Build Quality", Value = "5" }
            };
            var FourthItems = new[] {
                new { Text = "", Value = "0" },
                new { Text = "Performance", Value = "1" },
                new { Text = "Display", Value = "2" },
                new { Text = "Camera", Value = "3" },
                new { Text = "Battary/Charging", Value = "4" },
                new { Text = "Build Quality", Value = "5" }
            };
            var FifthItems = new[] {
                new { Text = "", Value = "0" },
                new { Text = "Performance", Value = "1" },
                new { Text = "Display", Value = "2" },
                new { Text = "Camera", Value = "3" },
                new { Text = "Battary/Charging", Value = "4" },
                new { Text = "Build Quality", Value = "5" }
            };
            FirstCombo.DataSource = Firstitems;
            SecondCombo.DataSource =Secitems;
            thirdCombo.DataSource = ThirdItems;
            fourthCombo.DataSource = FourthItems;
            fifthCombo.DataSource = FifthItems;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMob.Rows.Clear();
                clsGetSpeac ob=new clsGetSpeac();
                List<MobileSpaceObject> mobs = new List<MobileSpaceObject>();
                mobs = ob.GetAllMobile();
                List<MobileSpaceObject> PricedMob = new List<MobileSpaceObject>();
                for (int i = 0; i < mobs.Count; i++)
                {
                    if (mobs[i].Price<=Convert.ToInt64( txtPrice.Text))
                    {
                        PricedMob.Add(mobs[i]);
                    }
                }
                int j = Convert.ToInt32(FirstCombo.SelectedValue);
                int k = Convert.ToInt32(SecondCombo.SelectedValue);
                int l = Convert.ToInt32(thirdCombo.SelectedValue);
                int m = Convert.ToInt32(fourthCombo.SelectedValue);
                int n = Convert.ToInt32(fifthCombo.SelectedValue);
                string userId = j + "" + k + "" + l + "" + m + "" + n;
                for (int i = 0; i < PricedMob.Count; i++)
                {
                    //Load sample data
                    var sampleData = new Recomended.MLModel1.ModelInput()
                    {
                        Userid = Convert.ToSingle(userId),
                        Mobid = PricedMob[i].MobileID,
                    };
                    //Load model and predict output
                    var result = Recomended.MLModel1.Predict(sampleData);

                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvMob);
                    //row.Cells[0].Value = i;
                    row.Cells[1].Value = PricedMob[i].MobileID;
                    row.Cells[2].Value = PricedMob[i].MobileName;
                    row.Cells[3].Value = result.Score;
                    dgvMob.Rows.Add(row);
                }
                //sort 
                dgvMob.Sort(dgvMob.Columns[3],System.ComponentModel.ListSortDirection.Descending);
                //select First row
                int s = 1;
                foreach (DataGridViewRow row in dgvMob.Rows)
                {
                    row.Cells[0].Value = s++;
                }
                dgvMob.Rows[0].Cells[0].Selected = true;
                //Load sample data
                var _sampleData = new Recomended.MLModel1.ModelInput()
                {
                    Userid = Convert.ToSingle(userId),
                    Mobid = Convert.ToSingle(txtMobId.Text),
                };
                //Load model and predict output
                var _result = Recomended.MLModel1.Predict(_sampleData);
                lblResult.Text = _result.Score.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

    }
}