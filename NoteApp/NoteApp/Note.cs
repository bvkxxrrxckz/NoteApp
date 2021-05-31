using System;

namespace NoteApp
{
	/// <summary>
	/// Класс заметки,который хранит в себе информацию
	/// о названии, категории, тексте,
	/// дате создания и последнего изменения заметки.
	/// </summary>
	public class Note:ICloneable
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
			set { _category = value; }
		}

		/// <summary>
		/// Задает и возращает текст заметки.
		/// </summary>
		public string Text
		{
			get { return _text; }
			set { _text = value; }
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
		public Note(string title,NoteCategory category,string text)
		{
			this.Title = title;
			this.Category = category;
			this.Text = text;
			this._created = DateTime.Now;
			this._modified = DateTime.Now;
		}

		/// <summary>
		/// Происходит клонирование класса.
		/// </summary>
		/// <returns></returns>
		public object Clone()
		{
			return MemberwiseClone();
		}
	}
}
