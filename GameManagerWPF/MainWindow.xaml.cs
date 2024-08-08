using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameManagerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private StoryLinkedList gameScriptList;
        private System.Collections.Generic.List<string> sortedScript;
        private int currentIndex = 0;


        public MainWindow()
        {
            InitializeComponent();
            InitializeGameScript();
        }

        private void InitializeGameScript()
        {
            gameScriptList = PopulateLinkedList();
            gameScriptList.Sort();
            sortedScript = gameScriptList.GetSortedScript().ToList();

            txtbox1.Text = string.Join("\n\n", sortedScript);
            DisplayCurrentLine();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayCurrentLine();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (currentIndex < sortedScript.Count - 1)
            {
                currentIndex++;
                DisplayCurrentLine();
            }
        }
        private void DisplayCurrentLine()
        {
            txtbox2.Text = sortedScript[currentIndex];
        }

        private StoryLinkedList PopulateLinkedList()
        {
            StoryLinkedList gameScriptList = new StoryLinkedList();

            gameScriptList.AddNode(3, "With every line of code mastered, Alex gains experience points, leveling up and unlocking new abilities like Debugging Dash and Algorithmic Aura.");
            gameScriptList.AddNode(12, "The tale of Alex, the IT student-turned-digital-legend, is forever etched in the annals of Cybersphere, inspiring aspiring programmers to pursue their dreams.");
            gameScriptList.AddNode(4, "The Firewall Fortress looms ahead, its defenses formidable, but Alex's mastery of cybersecurity allows them to breach the walls with a series of perfectly timed hacks.");
            gameScriptList.AddNode(2, "Armed with a trusty keyboard and a digital sword, Alex enters the Coding Caverns, where bugs and glitches guard the treasures of programming wisdom.");
            gameScriptList.AddNode(1, "In the virtual realm of Cybersphere, our hero, Alex, a determined IT student, embarks on an epic quest for knowledge.");
            gameScriptList.AddNode(7, "Along the journey, Alex forges alliances with NPC coders, forming a guild known as 'Syntax Sentinels,' united by their dedication to digital mastery.");
            gameScriptList.AddNode(10, "Victory is hard-won, but Alex's leadership and IT prowess lead to the defeat of the Malware Marauders, restoring peace to Cybersphere.");
            gameScriptList.AddNode(11, "Celebrated as a digital hero, Alex stands at the forefront of innovation, using the knowledge gained to create groundbreaking applications that shape the future of technology.");
            gameScriptList.AddNode(9, "In a climactic battle, Alex and the Syntax Sentinels engage in a virtual war, using complex algorithms and strategic thinking to outwit the Malware Marauders' schemes.");
            gameScriptList.AddNode(5, "Inside the fortress, a virtual reality riddle awaits – a puzzle that can only be solved by applying principles of encryption and decryption learned during countless late-night study sessions.");
            gameScriptList.AddNode(6, "Emerging victorious, Alex discovers the hidden Repository of the Ancients, a collection of long-lost IT texts rumored to contain the ultimate programming language.");
            gameScriptList.AddNode(8, "The guild faces its nemesis in the form of the Malware Marauders, a rival group aiming to spread chaos and disrupt the digital realm.");

            return gameScriptList;
        }
    }




}
