# Caching in asp.net
- Caching is a technique for storing frequently used data or information in memory. 
- When the same data or information is needed next time, it could be directly retrieved from the memory instead of being generated by the application.
- It is important for data related transactions.
- ASP.NET provides the following different types of caching:<br>
1. Output Caching<br>
2. Data Caching<br>
3. Object Caching<br>

# Output caching:-
- Output cache stores a copy of the finally rendered HTML pages or part of pages sent to the client.
- When the next client requests for this page, instead of regenerating the page, a cached copy of the page is sent, thus saving time.<br>
Syntax:-<br>
<%@ OutputCache Duration="15" VaryByParam="None" %> <br>
protected void Page_Load(object sender, EventArgs e)<br>
{<br>
   Thread.Sleep(10000);<br>
   Response.Write("This page was generated and cache at:" +<br>
   DateTime.Now.ToString());<br>
}

# Data caching:-
- Data caching means caching data from a data source.
- As long as the cache is not expired, a request for the data will be fulfilled from the cache.
- When the cache is expired, fresh data is obtained by the data source and the cache is refilled.<br>
Syntax:-<br>
<asp:Label ID="lbltime" runat="server"></asp:Label><br>
protected void Page_Load(object sender, EventArgs e)<br>
{<br>
   lbltime.Text = String.Format("Page posted at: {0}", DateTime.Now.ToLongTimeString());<br>
}

# Object caching:-
- Object caching is used for caching the objects on a page.
- The cached data is stored in server memory.<br>
Syntax:-<br>
Cache["key"] = item;<br>
Cache.Insert("my_item", obj, null, DateTime.MaxValue, TimeSpan.FromMinutes(10));<br>
protected void Page_Load(object sender, EventArgs e)<br>
{<br>
   if (this.IsPostBack)<br>
   {
      lblinfo.Text += "Page Posted Back.";<br/>
   }<br>
   else<br>
   {<br>
      lblinfo.Text += "page Created.";<br/>
   }<br>
   
   if (Cache["testitem"] == null)<br>
   {<br>
      lblinfo.Text += "Creating test item.";<br/>
      DateTime testItem = DateTime.Now;<br>
      lblinfo.Text += "Storing test item in cache ";<br>
      lblinfo.Text += "for 30 seconds.";<br/>
      Cache.Insert("testitem", testItem, null, DateTime.Now.AddSeconds(30), TimeSpan.Zero);<br>
   }<br>
   else<br>
   {<br>
      lblinfo.Text += "Retrieving test item.<br/>";<br>
      DateTime testItem = (DateTime)Cache["testitem"];<br>
      lblinfo.Text += "Test item is: " + testItem.ToString();<br>
      lblinfo.Text += " "; <br/>
   }<br>
      
   lblinfo.Text += " "; <br/>
}
