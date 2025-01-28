

#region using statements


#endregion

namespace Clock
{

    #region class ClockForm
    /// <summary>
    /// This class is a big font clock because I can't read Windows 11 clock, and Windows 11 clock doesn't open when clicked on.
    /// </summary>
    public partial class ClockForm : Form
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'ClockForm' object.
        /// </summary>
        public ClockForm()
        {
            // Create Controls
            InitializeComponent();

            // setup the timer
            Timer.Enabled = true;
            TimeLabel.ForeColor = Color.Firebrick;
            TimeLabel.Dock = DockStyle.Fill;
            TimeLabel.TextAlign = ContentAlignment.MiddleCenter;

            // Set the time at start up
            TimeLabel.Text = DateTime.Now.ToShortTimeString();

            // Update the date
            DateLabel.Text = DateTime.Now.DayOfWeek + " " + DateTime.Now.ToShortDateString();

            // Show on top
            TopLevel = true;
            TopMost = true;
        }
        #endregion

        #region Events

        #region Timer_Tick(object sender, EventArgs e)
        /// <summary>
        /// event is fired when Timer _ Tick
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            // Update the time
            TimeLabel.Text = now.ToShortTimeString();

            // Update the date
            DateLabel.Text = now.DayOfWeek + " " + now.ToShortDateString();
        }
        #endregion

        #endregion

    }
    #endregion

}
