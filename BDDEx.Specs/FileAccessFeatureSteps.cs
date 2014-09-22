using System.Linq;
using System.Threading;
using BDDSampleEx.Automation.AutoIt;
using BDDSampleEx.Automation.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BDDEx.Specs
{
    [Binding]
    public class FileAccessFeatureSteps
    {
        [Given]
        public void Given_I_m_on_the_main_ex_ua_page()
        {
            Page<HomePage>.Instance().OpenMainPage();
        }

        [When]
        public void When_I_create_new_files_storage()
        {
            var newStorageAccessKey = Page<HomePage>.Instance().CreateNewStorage();

            ScenarioContext.Current.Add("StorageAccessKey", newStorageAccessKey);
        }

        [When]
        public void When_I_uploaded_new_files(Table table)
        {
            var files = table.Rows.Select(row => row["FilePath"]).ToArray();
            AutoIt.UploadFiles(files);

            // Дописать ожидалку загрузки файлов.
            Thread.Sleep(4000);
        }

        [Then]
        public void Then_files_should_be_marked_as_loaded(Table table)
        {
            var files = table.Rows.Select(row => row["FileName"]).ToArray();

            foreach (var file in files)
            {
                var currentFileStatus = Page<StorageEditPage>.Instance().FileStatus(file);
                Assert.AreEqual("loaded", currentFileStatus, "File \"" + file + "\" wasn't loaded");

            }
        }

        [Then]
        public void Then_the_new_storage_edit_page_should_be_opened()
        {
            Assert.IsTrue(Page<StorageEditPage>.Instance().CurrentUrl.Contains("edit_storage"),
                "Storage Edit page isn't opened");
        }

        [When]
        public void When_I_delete_the_storage()
        {
            Page<StoragePage>.Instance().DeleteStorage();

        }

        [When]
        public void When_I_open_the_storage_page()
        {
            var storageAccessKey = ScenarioContext.Current.Get<string>("StorageAccessKey");

            Page<HomePage>.Instance().OpenMainPage(ending:storageAccessKey);
            
        }

        [When]
        public void When_I_try_to_get_access_to_the_storage_by_access_key()
        {
            var storageAccessKey = ScenarioContext.Current.Get<string>("StorageAccessKey");

            Page<HomePage>.Instance().GetStorageByKey(storageAccessKey);

        }

        [Then]
        public void Then_the_storage_is_not_found()
        {
            Assert.IsTrue(Page<StorageIsNotFoundPage>.Instance().IsAt, "Error found page isn't opened.");
        }

        [Then]
        public void Then_I_m_got_access_to_the_storage()
        {
            var storageAccessKey = ScenarioContext.Current.Get<string>("StorageAccessKey");

            var currentStorageId = Page<StoragePage>.Instance().StorageID;
            var currentUrl = Page<StoragePage>.Instance().CurrentUrl;

            Assert.AreEqual(storageAccessKey, currentStorageId, "Storage id doesn't match.");
            Assert.IsTrue(currentUrl.Contains(storageAccessKey), "Url doesn't containt storage id.");

        }

        [When]
        public void When_I_try_to_get_access_to_the_storage_by_pageurl()
        {
            //var storageAccessKey = ScenarioContext.Current.Get<string>("StorageAccessKey");

            //Page<HomePage>.Instance().OpenMainPage(ending: storageAccessKey);

            When_I_open_the_storage_page();
            
        }

        [When]
        public void When_I_go_on_the_main_ex_ua_page()
        {
            Page<HomePage>.Instance().OpenMainPage();
        }

        [Given]
        public void Given_I_try_to_get_access_to_the_storeage_by_access_key_KEY(string key)
        {
            ScenarioContext.Current.Add("StorageAccessKey", key);

            Page<HomePage>.Instance().GetStorageByKey(key);
        }
    }
}
