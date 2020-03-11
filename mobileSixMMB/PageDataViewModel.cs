using System;
using System.Collections.Generic;

namespace mobileSixMMB
{
    public class PageDataViewModel
    {
        public PageDataViewModel(Type type, string title)
        {
            Type = type;
            Title = title;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        static PageDataViewModel()
        {
            All = new List<PageDataViewModel>
            {
                new PageDataViewModel(typeof(ActivityOnePage), "Activity One"),

                new PageDataViewModel(typeof(ActivityTwoPage), "Activity Two"),

                new PageDataViewModel(typeof(ActivityThreePage), "Activity Three")
            };
        }

        public static IList<PageDataViewModel> All { private set; get; }
    }
}
