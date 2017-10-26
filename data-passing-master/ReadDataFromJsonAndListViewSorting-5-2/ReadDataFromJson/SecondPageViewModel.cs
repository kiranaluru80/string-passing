using System;
namespace ReadDataFromJson
{
	public class SecondPageViewModel : ViewModelBase
	{
		public MyJsseResponse.RootObjectJSSE _selecteJSSEObject;


		public SecondPageViewModel(MyJsseResponse.RootObjectJSSE selecteJSSEObject)
		{
			_selecteJSSEObject = selecteJSSEObject;
			firstLabel = selecteJSSEObject.Observer.FullName;
			SecondLabel = selecteJSSEObject.JSSEEnteredBy;
            EntryText = selecteJSSEObject.Observees[0].FullName;
		}

		string firstLabel;
		public string FirstLabel
		{
			get { return firstLabel; }
			set
			{
				if (firstLabel != value)
				{
					firstLabel = value;
					OnPropertyChanged("FirstLabel");
				}
			}
		}

		string entryText;
		public string EntryText
		{
			get { return entryText; }
			set
			{
				if (entryText != value)
				{
					entryText = value;
					OnPropertyChanged("EntryText");
				}
			}
		}
		string secondLabel;
		public string SecondLabel
		{
			get { return secondLabel; }
			set
			{
				if (secondLabel != value)
				{
					secondLabel = value;
					OnPropertyChanged("SecondLabel");
				}
			}
		}
	}
}
