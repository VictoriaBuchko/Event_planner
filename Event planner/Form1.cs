namespace Event_planner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(AddEvent, "Додати нову подію");
            toolTip.SetToolTip(DeleteEvent, "Видалити вибрану подію");
            toolTip.SetToolTip(ButtonEventFinish, "Виберіть подію зі списку, і натисніть на кнопку, щоб позначити подію як виконану");
            toolTip.SetToolTip(listBoxEvent, "Список подій");
            toolTip.SetToolTip(progressBar1, "Шкала прогресу виконання подій");
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private List<Event> events = new List<Event>();

        private class Event
        {
            public string Name { get; set; }
            public DateTime Date { get; set; }
            public bool IsCompleted { get; set; }

            public override string ToString()
            {
                return $"{Name} - {Date.ToShortDateString()} {(IsCompleted ? "(Виконано)" : "")}";
            }
        }

        private void AddEvent_Click(object sender, EventArgs e)
        {
            string eventName = textBoxEventName.Text;
            DateTime eventDate = dateTimePicker1.Value;

            if (string.IsNullOrWhiteSpace(eventName))
            {
                MessageBox.Show("Введіть назву події", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Event newEvent = new Event
            {
                Name = eventName,
                Date = eventDate,
                IsCompleted = false
            };

            events.Add(newEvent);
            listBoxEvent.Items.Add(newEvent);
            UpdateProgressBar();
        }

        private void ButtonEventFinish_Click_1(object sender, EventArgs e)
        {
            if (listBoxEvent.SelectedItem != null)
            {
                Event selectedEvent = (Event)listBoxEvent.SelectedItem;
                selectedEvent.IsCompleted = true;
                listBoxEvent.Items[listBoxEvent.SelectedIndex] = selectedEvent;
                UpdateProgressBar();
            }
            else
            {
                MessageBox.Show("Виберіть подію для позначення як виконану", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProgressBar()
        {
            int totalEvents = events.Count;
            int completedEvents = events.Count(e => e.IsCompleted);

            if (totalEvents == 0)
            {
                progressBar1.Value = 0;
            }
            else
            {
                int progress = (completedEvents * 100) / totalEvents;
                progressBar1.Value = progress;
            }
        }

        private void InitializeProgressBar()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeProgressBar();
        }

        private void DeleteEvent_Click_1(object sender, EventArgs e)
        {
            if (listBoxEvent.SelectedItem != null)
            {
                Event selectedEvent = (Event)listBoxEvent.SelectedItem;
                events.Remove(selectedEvent);
                listBoxEvent.Items.Remove(selectedEvent);
                UpdateProgressBar();
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть подію для видалення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
