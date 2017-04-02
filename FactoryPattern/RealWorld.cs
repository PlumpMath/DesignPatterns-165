using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Document()
        {
            this.CreatePages();
        }

        // Factory Method
        public abstract void CreatePages();

        private List<Page> _pages = new List<Page>();

        public List<Page> Pages
        {
            get { return _pages; }
        }
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

    class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
