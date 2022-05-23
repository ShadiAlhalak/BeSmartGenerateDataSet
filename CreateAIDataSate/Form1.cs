
using RatingMobs;

namespace CreateAIDataSate
{
    public partial class Form1 : Form
    {
        clsGetSpeac ob;
        List<MobileSpaceObject> mobs=new List<MobileSpaceObject>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mobs = ob.GetAllMobile();
            MessageBox.Show("Done");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ob = new clsGetSpeac();
            MessageBox.Show("Done");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> ss= new List<string>();
            ss.Add("userid,mobid,rating");
            for (int s = 0; s<mobs.Count-1; s++)
            {
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= 5 ; j++)
                    {
                        for (int k = 1; k <= 5 ; k++)
                        {
                            for (int l = 1; l <= 5 ; l++)
                            {
                                for (int m = 1; m <= 5 ; m++)
                                {
                                    if (i == j | i == k | i == l | i == m | j == k | j == l | j == m | k == l | k == m | l == m)
                                    { 
                                    
                                    }
                                    else
                                    {
                                        int PriceRange = 0;
                                        if (200 >= mobs[s].Price)
                                        {
                                            PriceRange = 6;
                                        }
                                        else if (250 >= mobs[s].Price)
                                        {
                                            PriceRange = 7;
                                        }
                                        else if (300 >= mobs[s].Price)
                                        {
                                            PriceRange = 8;
                                        }
                                        else if (350 >= mobs[s].Price)
                                        {
                                            PriceRange = 9;
                                        }
                                        else
                                        {
                                            PriceRange = 0;
                                        }
                                      
                                        string n = i + "" + j + "" + k + "" + l + "" + m;
                                        var sampleData = new MLModel1.ModelInput()
                                        {
                                            Userid = Convert.ToSingle(n),
                                            Performance = mobs[s].Performance,
                                            Display = mobs[s].Display,
                                            Camera = mobs[s].Camera,
                                            Battary = mobs[s].Battary,
                                            BuildQuality = mobs[s].BuildQuality,
                                            Price = mobs[s].Price,
                                        };
                                        var result = MLModel1.Predict(sampleData);
                                        ss.Add(sampleData.Userid.ToString()+ "," + mobs[s].MobileID + "," + result.Score.ToString());
                                        //ss.Add(sampleData.Userid.ToString() + PriceRange+ ","+mobs[s].MobileID+","+ result.Score.ToString());
                                    }
                                }
                            }
                        }
                    }
                }
            }
            MessageBox.Show("Rating " + ss.Count.ToString());
            //Change path to your output file path
            File.AppendAllLines(@"C:\Users\shadi\Desktop\Output\output.txt",ss);
        }
    }
}