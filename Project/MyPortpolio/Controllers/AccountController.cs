using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyPortpolio.Data;
using MyPortpolio.Models;

namespace MyPortpolio.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            var account = new Account();
            return View(account);
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("Email,Password")] Account account)
        {
            if (ModelState.IsValid)
            {
                var result = CheckAccount(account.Email, account.Password);
                if (result == null)
                { // 계정이 없음 화면을 Home/Index 이동
                    ViewBag.Message = "해당 계정이 없습니다";
                    return View("Login");
                }
                else
                { // 로그인
                    HttpContext.Session.SetString("UserEmail", result.Email);
                    return RedirectToAction("Index", "Home");
                }
            }

            return View("Login"); // null 에서
        }

        private Account CheckAccount(string email, string password)
        {
            return _context.Account.SingleOrDefault(a => a.Email.Equals(email) && a.Password.Equals(password));
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Email,Password")] Account account)
        { 
            try
            {
                if (ModelState.IsValid)
                { 
                    _context.Add(account);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Login));
                }

                return View(account);
            }
            catch (Exception ex)
            {
                TempData["testmsg"] = "<script>alert('회원가입이 완료됬습니다.');</script>";
                ViewBag.Message = "해당 계정이 없습니다";
                return View("Create");
            }
        }
    }
}
