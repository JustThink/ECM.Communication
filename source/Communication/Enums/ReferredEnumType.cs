using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECM.Communication.Enums
{
	/// <summary>
	/// Определение вида ссылки
	/// <remarks>
	/// Используется только совместно с атрибутом idnumber
	/// </remarks>
	/// </summary>
	public enum ReferredEnumType : sbyte
	{
		//ссылка на документ;
		link_to_doc = 1,
		//ссылка на задание
		link_to_task = 2,
	}
}
