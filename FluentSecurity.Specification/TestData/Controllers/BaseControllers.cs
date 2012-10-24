﻿using System.Web.Mvc;

namespace FluentSecurity.Specification.TestData.Controllers
{
	namespace BaseControllers
	{
		public class IneritingBaseController : BaseController
		{
			public ActionResult FirstClassAction()
			{
				return null;
			}
		}

		public class IneritingAbstractBaseController : AbstractBaseController
		{
			public ActionResult FirstClassAction()
			{
				return null;
			}
		}

		public class InheritingGenericBaseController : GenericBaseController<InheritingEntity>
		{
			public ActionResult FirstClassAction()
			{
				return null;
			}
		}

		public class BaseController : Controller
		{
			public ActionResult InheritedAction()
			{
				return null;
			}
		}

		public abstract class AbstractBaseController : Controller
		{
			public ActionResult InheritedAction()
			{
				return null;
			}
		}

		public abstract class GenericBaseController<T> : Controller where T : BaseEntity
		{
			public ActionResult InheritedAction()
			{
				return null;
			}
		}

		public class InheritingEntity : BaseEntity {}

		public class BaseEntity {}
	}
}