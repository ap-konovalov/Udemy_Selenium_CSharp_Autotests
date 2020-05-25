namespace Interfaces_12_Tests.SectionExam
{
    public class PageObjectOne: IPageObject
    {
        public string PageName { get; }

        public PageObjectOne()
        {
            PageName = "Page Name 1";
        }
    }
}