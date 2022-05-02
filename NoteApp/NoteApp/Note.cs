using System;

namespace NoteApp
{
	/// <summary>
	/// Класс заметки,который хранит в себе информацию
	/// о названии, категории, тексте,
	/// дате создания и последнего изменения заметки.
	/// </summary>
	public class Note:ICloneable, IEquatable<Note>
	{
		/// <summary>
		/// Содержит название заметки.
		/// </summary>
		private string _title = "Без названия";

		/// <summary>
		/// Содержит категорию заметки.
		/// </summary>
		private NoteCategory _category;

		/// <summary>
		/// Содержит текст заметки.
		/// </summary>
		private string _text;

		/// <summary>
		/// Содержит дату создания заметки.
		/// </summary>
		private DateTime _created; 

		/// <summary>
		/// Содержит дату последнего изменения заметки.
		/// </summary>
		private DateTime _modified;

		/// <summary>
		/// Задает и возращает название заметки.
		/// </summary>
		public string Title
		{
			get { return _title; }
			set
			{
				if (_title.Length > 50)
				{
					throw new ArgumentException("Название не должно привышать 50 символов.");
				}
				if (_title.Length == 0) 
				{
					_title = "Без навзавния";
				}
				else
				{
				_title = value;
				}
			}

		}

		/// <summary>
		/// Задает и возвращает категорию заметки.
		/// </summary>
		public NoteCategory Category
		{
			get { return _category; }
			set { _category = value; Modified = DateTime.Now; }
		}

		/// <summary>
		/// Задает и возращает текст заметки.
		/// </summary>
		public string Text
		{
			get { return _text; }
			set { _text = value; Modified = DateTime.Now; }
		}

		/// <summary>
		/// Задает и возразщает дату создания заметки.
		/// </summary>
		public DateTime Created
		{
			get { return _created; }
            private set { _created = value; }
        }

		/// <summary>
		/// Задает и возращает дату изменения заметки.
		/// </summary>
		public DateTime Modified
		{
			get { return _modified; }
			set { _modified = value; }
		}

		/// <summary>
		/// Конструктор класса.
		/// </summary>
		public Note(NoteCategory category)
		{
			Category = category;
		}

        public Note()
        {

        }
		public Note(string title, NoteCategory category, string text, DateTime creationTime,
			DateTime modificationTime)
		{
			Title = title;
			Category = category;
			Text = text;
			Created = creationTime;
			Modified = modificationTime;
		}

		/// <summary>
		/// Происходит клонирование класса.
		/// </summary>
		/// <returns></returns>
		public object Clone()
		{
			return MemberwiseClone();
		}

		public bool Equals(Note other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return (Title == other.Title
					&& Category == other.Category
					&& Text == other.Text
					&& Created.Equals(other.Created)
					&& Modified.Equals(other.Modified));
		}
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
			{
				return false;
			}

			if (ReferenceEquals(this, obj))
			{
				return true;
			}

			if (obj.GetType() != GetType())
			{
				return false;
			}

			return Equals((Note)obj);
		}
	}
}
