using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;

namespace SeleniumCrawler
{
    internal class Program
    {
        public static string[] serviceUrls = new string[] {
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Other/EnableSearchService/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Other/ForumAuthNotification/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Other/RatingService/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Other/OceanChannelRelationServiceTransfer/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Other/Forum.Ocean.ManagementSystem/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Columnist/ColumnistService/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Utils/PCoinSender/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Utils/PopularStatisticsTool/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Article/LabelArticleService/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Article/promotedarticleservice/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Article/articlereportcount/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Article/TopicArticlePopularStatistics/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Article/PostChecker/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Group/GroupServiceUtil/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Group/GroupUnreadCountService/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Group/GroupService/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Group/GroupService.Admin/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Schedule/Forum.Ocean.Question/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Schedule/Forum.Ocean.ExpertStatistics/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Schedule/Forum.Ocean.ArticlePopularStatistics/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Schedule/Forum.Ocean.ArticleSender/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/ChatroomService/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Forum.Ocean/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/ForumOceanService/Forum.Ocean.Service/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Article/ArticleService/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Article/SearchArticleService/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Other/InvestingBlog/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Other/StreamingMediaService/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Other/TopicService/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Other/StockReportToForumSender/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Space/SpaceMemberSearchable/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Space/SpaceService/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Space/SpaceService.Admin/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Space/SpaceService.Api/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Utils/postmanscripts/Staging/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Utils/SyncMemberSearchService/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Utils/YamlEnvReplacer/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Utils/JsonToEnvironmentParser/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Utils/GitOpsTemplate/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Utils/RedisCopyTool/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Utils/opstools/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Utils/gke_autodeployment/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Utils/CompatibilityTest/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Utils/ForumHealthChecker/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Utils/multipleap-cicdtest/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Member/SearchMemberService/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Member/MemberService.Admin/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Department/Member/MemberService/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Core/cmoney.forum.redis.converter/-/services/hangouts_chat/edit",
            //"http://192.168.10.147:8080/MultipleAP/Forum/Core/Forum.RepositoryService/-/services/hangouts_chat/edit",
            };
        static void Main(string[] args)
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
                webhookInput.SendKeys("https://chat.googleapis.com/v1/spaces/AAAAnd5HeBk/messages?key=AIzaSyDdI0hCZtE6vySjMm-WEfRq3CPzqKqqsHI&token=NGhsKBbsAxa5mHN3Md4rxva-EQ-VOsnJWT53DMS9_R4%3D");

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
}