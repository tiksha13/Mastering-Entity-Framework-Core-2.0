﻿using MasteringEFCore.MultiTenancy.Final.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringEFCore.MultiTenancy.Final.ViewComponents
{
    public class AddCommentViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke(int postId)
        {
            return View(new CommentViewModel() { PostId = postId });
        }
    }
}
