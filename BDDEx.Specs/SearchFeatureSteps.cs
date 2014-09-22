using System;
using BDDSampleEx.Automation.Pages;
using TechTalk.SpecFlow;

namespace BDDEx.Specs
{
    [Binding]
    public class SearchFeatureSteps
    {
        [Given]
        public void Given_I_want_to_use_search()
        {
            Page<HomePage>.Instance().GoTo(Menu.Search);
        }
        
        [Given]
        public void Given_I_P0_contentId(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given]
        public void Given_I_m_on_the_content_page()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When]
        public void When_I_enter_TEXTSEARCH_to_input_field(string textsearch)
        {
            Page<SearchPage>.Instance().EnterSearchText(textsearch);
        }
        
        [When]
        public void When_I_press_search_button()
        {
            Page<SearchPage>.Instance().ClickSearch();
        }
        
        [When]
        public void When_I_Press_play_button_for_the_playable_file()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When]
        public void When_I_click_on_the_player_window()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When]
        public void When_I_close_player_window()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When]
        public void When_I_click_load_for_the_file()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then]
        public void Then_the_search_result_should_contain_P0_string(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then]
        public void Then_It_should_playing()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then]
        public void Then_It_should_stop_playing()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then]
        public void Then_It_should_be_closed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then]
        public void Then_It_should_downloading()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then]
        public void Then_It_should_be_downloaded()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
