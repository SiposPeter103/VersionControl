using Mikroszimuláció.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;


namespace Mikroszimuláció
{
    public partial class Form1 : Form
    {
        List<Person> Population = new List<Person>();
        List<BirthProbability> BirthProbabilities = new List<BirthProbability>();
        List<DeathProbability> DeathProbabilities = new List<DeathProbability>();
        List<int> MalePop = new List<int>();
        List<int> FemalePop = new List<int>();
        Random rng = new Random(1234);
        public Form1()
        {
            InitializeComponent();

            Population = GetPopulation(textBox1.Text);
            BirthProbabilities = GetBirthProbabilities(@"C:\Temp\születés.csv");
            DeathProbabilities = GetDeathProbabilities(@"C:\Temp\halál.csv");
            

        }

        private void Simulation()
        {
            for(int year = 2005; year < numericUpDown1.Value; year++)
            {
                
                for(int i = 0; i < Population.Count; i++)
                {
                    SimStep(year, Population[i]);
                }
                int numOfMales = (from x in Population
                                  where x.Gender == Gender.Male && x.IsAlive
                                  select x).Count();
                int numOfFemales = (from y in Population
                                    where y.Gender == Gender.Female && y.IsAlive
                                    select y).Count();
                Console.WriteLine(string.Format("Év:{0} Fiúk:{1} Lányok:{2}", year, numOfMales, numOfFemales));
                MalePop.Add(numOfMales);
                FemalePop.Add(numOfFemales);
                
                
            }
        }

        public List<Person> GetPopulation(string csvpath)
        {
            List<Person> population = new List<Person>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    population.Add(new Person()
                    {
                        BirthYear = int.Parse(line[0]),
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                        NumOfChildren = int.Parse(line[2])
                    });
                }
            }

            return population;
        }

        public List<BirthProbability> GetBirthProbabilities(string csvpath)
        {
            List<BirthProbability> birthprob = new List<BirthProbability>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    birthprob.Add(new BirthProbability()
                    {
                        Age = int.Parse(line[0]),
                        NumOfChildren = int.Parse(line[1]),
                        OddsOfBirth = double.Parse(line[2])
                    });
                }
            }
            return birthprob;
        }

        public List<DeathProbability> GetDeathProbabilities(string csvpath)
        {
            List<DeathProbability> deathprob = new List<DeathProbability>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    deathprob.Add(new DeathProbability()
                    {
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[0]),
                        Age = int.Parse(line[1]),
                        OddsOfDeath = double.Parse(line[2])
                    });
                }
            }
            return deathprob;
        }

        public void SimStep(int year, Person person)
        {
            if (!person.IsAlive) return;
            int age = (int)(year - person.BirthYear);


            double oddsOfDeath = (from x in DeathProbabilities
                                  where x.Gender == person.Gender && x.Age == age
                                  select x.OddsOfDeath).FirstOrDefault();
            if (rng.NextDouble() <= oddsOfDeath) person.IsAlive = false;


            if (person.IsAlive && person.Gender == Gender.Female)
            {
                double oddsOfBirth = (from x in BirthProbabilities
                                      where x.Age == age
                                      select x.OddsOfBirth).FirstOrDefault();
                if(rng.NextDouble() <= oddsOfBirth)
                {
                    Person ujszulott = new Person();
                    ujszulott.BirthYear = year;
                    ujszulott.Gender = (Gender)(rng.Next(1, 3));
                    ujszulott.IsAlive = true;
                    ujszulott.NumOfChildren = 0;
                    Population.Add(ujszulott);
                }
            }
        }

        public void DisplayResults()
        {
            for (int year = 2005; year < numericUpDown1.Value; year++)
            {
                int i = 0;
                richTextBox1.Text += "Szimulációs év:" + year + "\n\t Fiúk:" + MalePop[i] + "\n\t Lányok:" + FemalePop[i] + "\n\n";
                i++;
                
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Start");
            Simulation();
            DisplayResults();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFile.FileName;
            } 
        }
    }
}
