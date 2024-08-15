using Microsoft.AspNetCore.Mvc;
using examWeek7.Models;
using System.Reflection;
using System.Net.Http.Headers;

namespace examWeek7.Controllers
{
	public class ManageController : Controller
	{
		string Baseurl = "https://fakestoreapi.com/products";
		public async Task<ActionResult> Index()
		{
			List<Book> EmpInfo = new List<Book>();
			using (var client = new HttpClient())
			{
				//Passing service base url
				client.BaseAddress = new Uri(Baseurl);
				client.DefaultRequestHeaders.Clear();
				//Define request data format
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				//Sending request to find web api REST service resource GetAllEmployees using HttpClient
				HttpResponseMessage Res = await client.GetAsync("api/Employee/GetAllEmployees");
				//Checking the response is successful or not which is sent using HttpClient
				if (Res.IsSuccessStatusCode)
				{
					//Storing the response details recieved from web api
					var EmpResponse = Res.Content.ReadAsStringAsync().Result;
					//Deserializing the response recieved from web api and storing into the Employee list
					EmpInfo = JsonConvert.DeserializeObject<List<Book>>(EmpResponse);
				}
				//returning the employee list to view
				return View(EmpInfo);
			}
		}
		
		
	}
}
