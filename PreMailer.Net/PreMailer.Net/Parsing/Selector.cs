﻿// No usings needed

namespace PreMailerDotNet.Parsing
{
	public class Selector
	{
		/// <summary>
		/// Gets or sets the selector.
		/// </summary>
		/// <value>The selector.</value>
		public string SelectorName { get; set; }

		/// <summary>
		/// Gets or sets the type of the selector.
		/// </summary>
		/// <value>The type of the selector.</value>
		public SelectorTypes SelectorType { get; set; }

		/// <summary>
		/// Gets or sets the CSS specificity.
		/// </summary>
		/// <value>The CSS specificity.</value>
		/// <remarks>What the heck is CSS Specificity? http://designshack.net/articles/css/what-the-heck-is-css-specificity/ </remarks>
		public int Specificity { get; set; }

		/// <summary>
		/// Returns a <see cref="System.String"/> that represents this instance.
		/// </summary>
		/// <returns>
		/// A <see cref="System.String"/> that represents this instance.
		/// </returns>
		public override string ToString()
		{
			return this.SelectorName;
		}
	}
}