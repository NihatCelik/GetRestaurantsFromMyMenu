using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace GetRestaurantsFromMyMenu
{
    public partial class Form1 : Form
    {
        string baseLink = "https://www.mymenu.be/";
        string postalCodesFileName = "PostalCodes.txt";
        string restaurantLinksFileName = "RestaurantLinks.txt";
        List<string> listPostalCodes;
        List<Restaurants> listRestaurants;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadPostalCodes_Click(object sender, EventArgs e)
        {
            listPostalCodes = new List<string>();
            if (!File.Exists(postalCodesFileName))
            {
                File.Create(postalCodesFileName);
                return;
            }

            StreamReader sr = new StreamReader(postalCodesFileName);
            while (!sr.EndOfStream)
            {
                listPostalCodes.Add(sr.ReadLine());
            }
            sr.Close();
            MessageBox.Show("File Read.");
        }

        private async void btnScanPostalCodes_Click(object sender, EventArgs e)
        {
            listRestaurants = new List<Restaurants>();
            IWebDriver driver = new ChromeDriver();//Google Chrome’un açılması için yapıyoruz. Aynı zamanda driver diye nesne tanımlamış olduk. Bu nesne üzerinden işlemleri yapacağız.
            driver.Manage().Window.Maximize();

            for (int i = 0; i < listPostalCodes.Count; i++)
            {
                this.Text = (i + 1).ToString() + "/" + listPostalCodes.Count.ToString();
                git:
                try
                {
                    driver.Navigate().GoToUrl(baseLink);
                    Wait(driver);
                    string postalCode = listPostalCodes[i];
                    IWebElement txtInput = driver.FindElement(By.TagName("input"));
                    txtInput.Clear();
                    txtInput.SendKeys(postalCode);
                    var element = driver.FindElement(By.CssSelector("div[class='uix-button uix-orange-background']"));
                    element.Click();
                    Wait(driver);

                    if (driver.Url == baseLink) continue;
                    HtmlDocument web = new HtmlDocument();
                    web.LoadHtml(driver.PageSource);

                    webBrowser1.Navigate(driver.Url);
                    while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                    {
                        Application.DoEvents();
                    }
                    var elementRestaurants = webBrowser1.Document.GetElementsByTagName("a")
                              .Cast<HtmlElement>()
                              .Where(f => !String.IsNullOrEmpty(f.GetAttribute("data-role"))
                                  && f.GetAttribute("data-role").Contains("restaurants"));

                    foreach (HtmlElement item in elementRestaurants)
                    {
                        string link = item.OuterHtml;
                        link = link.Substring(link.IndexOf("href") + 7);
                        link = link.Substring(0, link.IndexOf("data-role") - 2);
                        listRestaurants.Add(new Restaurants { PostalCode = postalCode, URL = baseLink + link });
                    }

                }
                catch (Exception)
                {
                    Wait(driver);
                    goto git;
                }
            }
            MessageBox.Show("Scan Finished.");
        }

        private static void Wait(IWebDriver driver)
        {
            Thread.Sleep(1500);
            new WebDriverWait(driver, TimeSpan.FromSeconds(3000)).Until(
                  d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }

        private void btnSaveRestaurantLinks_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(restaurantLinksFileName);
            foreach (var item in listRestaurants)
            {
                sw.WriteLine(item.PostalCode + ";" + item.URL);
            }
            sw.Close();
        }

        private void btnReadRestaurantLinks_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listRestaurants = new List<Restaurants>();
            StreamReader sr = new StreamReader(restaurantLinksFileName);
            while (!sr.EndOfStream)
            {
                string lines = sr.ReadLine();
                string[] line = Regex.Split(lines, ";");
                listRestaurants.Add(new Restaurants { PostalCode = line[0], URL = line[1] });
                listBox1.Items.Add(lines);
            }
            MessageBox.Show("File Read.");
        }

        private void btnScanRestaurantsFromLinks_Click(object sender, EventArgs e)
        {
            for (int i = listRestaurants.Count - 1; i >= 0; i--)
            {
                this.Text = (i + 1).ToString() + "/" + listRestaurants.Count.ToString();
                Restaurants restaurants = listRestaurants[i];
                if (restaurants.URL == baseLink)
                {
                    listRestaurants.RemoveAt(i);
                    continue;
                }
                HtmlWeb web = new HtmlWeb();
                var doc = web.Load(restaurants.URL);
                string xPath = "/html/body/div/div[3]/div/div[1]/div/div[1]/div[1]/a";
                if (doc.DocumentNode.SelectNodes(xPath) != null) restaurants.Name = doc.DocumentNode.SelectNodes(xPath).FirstOrDefault().InnerText;

                xPath = "/html/body/div/div[3]/div/div[1]/div/div[1]/div[2]";
                if (doc.DocumentNode.SelectNodes(xPath) != null) restaurants.Address = doc.DocumentNode.SelectNodes(xPath).FirstOrDefault().InnerText;
            }
            MessageBox.Show("Scan Finished.");
        }

        private void btnWriteCSV_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(restaurantLinksFileName);
            foreach (var item in listRestaurants)
            {
                sw.WriteLine(item.PostalCode + ";" + item.Name + ";" + item.Address);
            }
            sw.Close();
            MessageBox.Show("CSV Written.");
        }

        private void btnReadCSV_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listRestaurants = new List<Restaurants>();
            StreamReader sr = new StreamReader(restaurantLinksFileName);
            while (!sr.EndOfStream)
            {
                string lines = sr.ReadLine();
                string[] line = Regex.Split(lines, ";");
                listRestaurants.Add(new Restaurants { PostalCode = line[0], Name = line[1], Address = line[2] });
                listBox1.Items.Add(lines);
            }
            MessageBox.Show("CSV Read.");
        }

        private void btnOpenInBrowser_Click(object sender, EventArgs e)
        {
            int start = Convert.ToInt32(nudStart.Value);
            int finish = Convert.ToInt32(nudFinish.Value);
            if (start > listRestaurants.Count) start = listRestaurants.Count - 1;
            if (finish > listRestaurants.Count) finish = listRestaurants.Count - 1;
            for (int i = start; i < finish; i++)
            {
                System.Diagnostics.Process.Start("https://www.google.com/search?q=" + listRestaurants[i].Name);
            }
        }
    }

    class Restaurants
    {
        public string URL { get; set; }
        public string PostalCode { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}