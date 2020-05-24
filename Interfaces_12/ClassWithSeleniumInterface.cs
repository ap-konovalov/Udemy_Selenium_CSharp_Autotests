using System.Collections.ObjectModel;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions.Internal;

namespace Interfaces_12
{
	public class ClassWithSeleniumInterface : IWebElement, IMouse
	{
		public IWebElement FindElement(By @by)
		{
			throw new System.NotImplementedException();
		}

		public ReadOnlyCollection<IWebElement> FindElements(By @by)
		{
			throw new System.NotImplementedException();
		}

		public void Clear()
		{
			throw new System.NotImplementedException();
		}

		public void SendKeys(string text)
		{
			throw new System.NotImplementedException();
		}

		public void Submit()
		{
			throw new System.NotImplementedException();
		}

		public void Click()
		{
			throw new System.NotImplementedException();
		}

		public string GetAttribute(string attributeName)
		{
			throw new System.NotImplementedException();
		}

		public string GetProperty(string propertyName)
		{
			throw new System.NotImplementedException();
		}

		public string GetCssValue(string propertyName)
		{
			throw new System.NotImplementedException();
		}

		public string TagName { get; }
		public string Text { get; }
		public bool Enabled { get; }
		public bool Selected { get; }
		public Point Location { get; }
		public Size Size { get; }
		public bool Displayed { get; }
		public void Click(ICoordinates @where)
		{
			throw new System.NotImplementedException();
		}

		public void DoubleClick(ICoordinates @where)
		{
			throw new System.NotImplementedException();
		}

		public void MouseDown(ICoordinates @where)
		{
			throw new System.NotImplementedException();
		}

		public void MouseUp(ICoordinates @where)
		{
			throw new System.NotImplementedException();
		}

		public void MouseMove(ICoordinates @where)
		{
			throw new System.NotImplementedException();
		}

		public void MouseMove(ICoordinates @where, int offsetX, int offsetY)
		{
			throw new System.NotImplementedException();
		}

		public void ContextClick(ICoordinates @where)
		{
			throw new System.NotImplementedException();
		}
	}
}