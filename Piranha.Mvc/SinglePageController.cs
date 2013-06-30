﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

using Piranha.Models;

namespace Piranha.Mvc
{
	/// <summary>
	/// The single page controller is the base controller from which all controllers
	/// representing a page should derive from.
	/// </summary>
	public class SinglePageController : BaseController
	{
		/// <summary>
		/// Gets the current page model.
		/// </summary>
		/// <returns>The model</returns>
		public PageModel GetModel() {
			return GetModel<PageModel>(CurrentPermalink) ;
		}

		/// <summary>
		/// Gets the current model.
		/// </summary>
		/// <typeparam name="T">The model type</typeparam>
		/// <returns>The model</returns>
		public T GetModel<T>() where T : PageModel {
			return GetModel<T>(CurrentPermalink) ;
		}

		/// <summary>
		/// Gets the page model identified by the given permalink.
		/// </summary>
		/// <param name="permalink">The permalink</param>
		/// <returns>The model</returns>
		public PageModel GetModel(string permalink) {
			return GetModel<PageModel>(permalink) ;
		}

		/// <summary>
		/// Gets the model identified by the given permalink.
		/// </summary>
		/// <typeparam name="T">The model type</typeparam>
		/// <param name="permalink">The permalink</param>
		/// <returns>The model</returns>
		public T GetModel<T>(string permalink) where T : PageModel {
			var m = PageModel.GetByPermalink<T>(permalink) ;

			HttpContext.Items["Piranha_CurrentPage"] = m.Page ;
			HttpContext.Items["Piranha_CurrentPost"] = null ;

			return m ;
		}

		/// <summary>
		/// Check if the current user has access to the action before continuing.
		/// </summary>
		/// <param name="context">The current context</param>
		protected override void OnActionExecuting(ActionExecutingContext context) {
			// Perform base class stuff
			base.OnActionExecuting(context) ;

			// Check permissions & client cache
			var page = Page.GetByPermalink(CurrentPermalink) ;
			if (page != null) {
				if (page.GroupId != Guid.Empty) {
					if (!User.IsMember(page.GroupId)) {
						SysParam param = SysParam.GetByName("LOGIN_PAGE") ;
						if (param != null)
							context.Result = Redirect(param.Value) ;
						else context.Result = Redirect("~/") ;
					}
					Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache) ;
				} else {
					// Only cache public non drafts
					DateTime mod = page.LastModified ;
					Web.ClientCache.HandleClientCache(HttpContext.ApplicationInstance.Context, 
						WebPages.WebPiranha.GetCulturePrefix() + page.Id.ToString(), mod) ;
				}
				// Check for disabled groups
				if (page.DisabledGroups.Contains(User.GetProfile().GroupId)) {
					SysParam param = SysParam.GetByName("LOGIN_PAGE") ;
					if (param != null)
						context.Result = Redirect(param.Value) ;
					else context.Result = Redirect("~/") ;
				}
			}
		}
	}
}
