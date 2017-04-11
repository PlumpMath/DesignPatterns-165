using System.Collections.Generic;

namespace FactoryPattern
{
    class RealWorld { }
    abstract class Page { }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class SkillPage : Page { }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class EducationPage : Page { }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class ExperiencePage : Page { }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class IntroductionPage : Page { }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class ResultsPage : Page { }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class ConclusionPage : Page { }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class SummaryPage : Page { }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class BibliographyPage : Page { }

    abstract class Document
    {
        protected Document()
        {
            // ReSharper disable once VirtualMemberCallInConstructor
            CreatePages();
        }

        // Factory Method
        public abstract void CreatePages();

        private List<Page> _pages = new List<Page>();

        public List<Page> Pages => _pages;
    }

    class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
