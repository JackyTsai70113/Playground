using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;

namespace SeleniumCrawler;

internal class Program
{
    public static string[] serviceUrls = Array.Empty<string>();
    static void Main()
    {
        // 建立 ChromeDriver
        var driver = new ChromeDriver();

        // 建立事件驅動
        var eventDriver = new EventFiringWebDriver(driver);

        foreach (var url in serviceUrls)
        {
            eventDriver.Navigate().GoToUrl(url);

            // note checkbox
            var noteCheckBox = eventDriver.FindElement(By.Id("service_note_events"));
            noteCheckBox.Click();

            // note checkbox
            var wikiPageCheckBox = eventDriver.FindElement(By.Id("service_wiki_page_events"));
            wikiPageCheckBox.Click();

            // note checkbox
            var webhookInput = eventDriver.FindElement(By.Id("service_webhook"));
            webhookInput.SendKeys("");

            // note checkbox
            var saveButton = eventDriver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div/div[2]/div[2]/form/div[3]/button"));
            saveButton.Click();
        }
    }

    static void OnElementClicked(object sender, WebElementEventArgs e)
    {
        Console.WriteLine($"Element clicked: {e.Element}");
    }

    static void OnElementValueChanging(object sender, WebElementValueEventArgs e)
    {
        Console.WriteLine($"Element value changing: {e.Element}");
    }

    static void OnFindElementCompleted(object sender, FindElementEventArgs e)
    {
        Console.WriteLine($"Find element completed: {e.FindMethod}");
    }

    static void OnNavigated(object sender, WebDriverNavigationEventArgs e)
    {
        Console.WriteLine($"Navigated to: {e.Url}");
    }
}