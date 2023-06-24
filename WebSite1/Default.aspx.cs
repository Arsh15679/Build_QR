using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!IsPostBack)
		{
			Unnamed_ServerClick(sender, e);
		}
	}

	//Preview the data button 
	protected void btn_Click(object sender, EventArgs e)
	{
		try
		{

			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#exampleModal').modal({backdrop: 'static', keyboard: false});", true);

			string path1 = Server.MapPath("~/LineHDT");
			string path2 = Server.MapPath("~/LineMDT");
			if (!Directory.Exists(path1))
			{
				string txt = "0000000";
				Directory.CreateDirectory(path1);
				TextWriter file = new StreamWriter(Server.MapPath("~/LineHDT/HDT.txt"));
				file.WriteLine(txt);
				file.Close();
			}
			if (!Directory.Exists(path2))
			{
				string txt = "0000000";
				Directory.CreateDirectory(path2);
				TextWriter file = new StreamWriter(Server.MapPath("~/LineMDT/MDT.txt"));
				file.WriteLine(txt);
				file.Close();
			}
			string partNumber = KpartNumber.Value;
			string desc = description.Value;
			string hmChk = string.Empty;
			if (chk_hdt.Checked == true)
			{
				hmChk = hdt.Text;
			}
			else
			{
				hmChk = mdt.Text;
			}
			string lineFirstLetter = hmChk.Substring(0, 1);

			if (hmChk == "HDT")
			{
				string val = System.IO.File.ReadAllText(Server.MapPath("~/LineHDT/HDT.txt"));
				string data = val.Replace("\r\n", "");
				int i = Convert.ToInt32(data.ToString());
				int j = i + 1;
				string sequnceNumber = "";
				if (j >= 0 && j <= 9)
				{
					sequnceNumber = "000000" + j;
					File.WriteAllText(Server.MapPath("~/LineHDT/HDT.txt"), sequnceNumber);
				}
				else if (j >= 10 && j <= 99)
				{
					sequnceNumber = "00000" + j;
					File.WriteAllText(Server.MapPath("~/LineHDT/HDT.txt"), sequnceNumber);
				}
				else if (j >= 100 && j <= 999)
				{
					sequnceNumber = "0000" + j;
					File.WriteAllText(Server.MapPath("~/LineHDT/HDT.txt"), sequnceNumber);
				}
				else if (j >= 1000 && j <= 9999)
				{
					sequnceNumber = "000" + j;
					File.WriteAllText(Server.MapPath("~/LineHDT/HDT.txt"), sequnceNumber);
				}
				else if (j >= 10000 && j <= 99999)
				{
					sequnceNumber = "00" + j;
					File.WriteAllText(Server.MapPath("~/LineHDT/HDT.txt"), sequnceNumber);
				}
				else if (j >= 100000 && j <= 999999)
				{
					sequnceNumber = "0" + j;
					File.WriteAllText(Server.MapPath("~/LineHDT/HDT.txt"), sequnceNumber);
				}
				string sMonth = DateTime.Now.ToString("MM");
				string sYear = DateTime.Now.ToString("yy");
				string alpha = "";
				if (sMonth == "01")
					alpha = "A";
				else if (sMonth == "02")
					alpha = "B";
				else if (sMonth == "03")
					alpha = "C";
				else if (sMonth == "04")
					alpha = "D";
				else if (sMonth == "05")
					alpha = "E";
				else if (sMonth == "06")
					alpha = "F";
				else if (sMonth == "07")
					alpha = "G";
				else if (sMonth == "08")
					alpha = "H";
				else if (sMonth == "09")
					alpha = "I";
				else if (sMonth == "10")
					alpha = "J";
				else if (sMonth == "11")
					alpha = "K";
				else if (sMonth == "12")
					alpha = "L";

				string FSN = "F" + lineFirstLetter + "S" + alpha + sYear + sequnceNumber;
				lblFsn.InnerText = FSN;
				lblKpart.InnerText = partNumber;
				lbldesc.InnerText = desc;
				lblLine.InnerText = hmChk;
			}
			else
			{
				string val = System.IO.File.ReadAllText(Server.MapPath("~/LineMDT/MDT.txt"));
				string data = val.Replace("\r\n", "");
				int i = Convert.ToInt32(data.ToString());
				int j = i + 1;
				string sequnceNumber = "";
				if (j >= 0 && j <= 9)
				{
					sequnceNumber = "000000" + j;
					File.WriteAllText(Server.MapPath("~/LineMDT/MDT.txt"), sequnceNumber);
				}
				else if (j >= 10 && j <= 99)
				{
					sequnceNumber = "00000" + j;
					File.WriteAllText(Server.MapPath("~/LineMDT/MDT.txt"), sequnceNumber);
				}
				else if (j >= 100 && j <= 999)
				{
					sequnceNumber = "0000" + j;
					File.WriteAllText(Server.MapPath("~/LineMDT/MDT.txt"), sequnceNumber);
				}
				else if (j >= 1000 && j <= 9999)
				{
					sequnceNumber = "000" + j;
					File.WriteAllText(Server.MapPath("~/LineMDT/MDT.txt"), sequnceNumber);
				}
				else if (j >= 10000 && j <= 99999)
				{
					sequnceNumber = "00" + j;
					File.WriteAllText(Server.MapPath("~/LineMDT/MDT.txt"), sequnceNumber);
				}
				else if (j >= 100000 && j <= 999999)
				{
					sequnceNumber = "0" + j;
					File.WriteAllText(Server.MapPath("~/LineMDT/MDT.txt"), sequnceNumber);
				}
				string sMonth = DateTime.Now.ToString("MM");
				string sYear = DateTime.Now.ToString("yy");
				string alpha = "";
				if (sMonth == "01")
					alpha = "A";
				else if (sMonth == "02")
					alpha = "B";
				else if (sMonth == "03")
					alpha = "C";
				else if (sMonth == "04")
					alpha = "D";
				else if (sMonth == "05")
					alpha = "E";
				else if (sMonth == "06")
					alpha = "F";
				else if (sMonth == "07")
					alpha = "G";
				else if (sMonth == "08")
					alpha = "H";
				else if (sMonth == "09")
					alpha = "I";
				else if (sMonth == "10")
					alpha = "J";
				else if (sMonth == "11")
					alpha = "K";
				else if (sMonth == "12")
					alpha = "L";

				string FSN = "F" + lineFirstLetter + "S" + alpha + sYear + sequnceNumber;
				lblFsn.InnerText = FSN;
				lblKpart.InnerText = partNumber;
				lbldesc.InnerText = desc;
				lblLine.InnerText = hmChk;
			}
		}
		catch (Exception exe)
		{

		}

	}

	//fsn should not change button
	protected void Unnamed_ServerClick(object sender, EventArgs e)
	{
		string hmChk = string.Empty;
		if (chk_hdt.Checked == true)
		{
			hmChk = hdt.Text;
		}
		else
		{
			hmChk = mdt.Text;
		}
		if (hmChk == "HDT")
		{
			string val = System.IO.File.ReadAllText(Server.MapPath("~/LineHDT/HDT.txt"));
			string data = val.Replace("\r\n", "");
			int i = Convert.ToInt32(data.ToString());
			int j = i - 1;
			string sequnceNumber = "";
			if (j >= 0 && j <= 9)
			{
				sequnceNumber = "000000" + j;
				File.WriteAllText(Server.MapPath("~/LineHDT/HDT.txt"), sequnceNumber);
			}
			else if (j >= 10 && j <= 99)
			{
				sequnceNumber = "00000" + j;
				File.WriteAllText(Server.MapPath("~/LineHDT/HDT.txt"), sequnceNumber);
			}
			else if (j >= 100 && j <= 999)
			{
				sequnceNumber = "0000" + j;
				File.WriteAllText(Server.MapPath("~/LineHDT/HDT.txt"), sequnceNumber);
			}
			else if (j >= 1000 && j <= 9999)
			{
				sequnceNumber = "000" + j;
				File.WriteAllText(Server.MapPath("~/LineHDT/HDT.txt"), sequnceNumber);
			}
			else if (j >= 10000 && j <= 99999)
			{
				sequnceNumber = "00" + j;
				File.WriteAllText(Server.MapPath("~/LineHDT/HDT.txt"), sequnceNumber);
			}
			else if (j >= 100000 && j <= 999999)
			{
				sequnceNumber = "0" + j;
				File.WriteAllText(Server.MapPath("~/LineHDT/HDT.txt"), sequnceNumber);
			}

		}
		else
		{
			string val = System.IO.File.ReadAllText(Server.MapPath("~/LineMDT/MDT.txt"));
			string data = val.Replace("\r\n", "");
			int i = Convert.ToInt32(data.ToString());
			int j = i - 1;
			string sequnceNumber = "";
			if (j >= 0 && j <= 9)
			{
				sequnceNumber = "000000" + j;
				File.WriteAllText(Server.MapPath("~/LineMDT/MDT.txt"), sequnceNumber);
			}
			else if (j >= 10 && j <= 99)
			{
				sequnceNumber = "00000" + j;
				File.WriteAllText(Server.MapPath("~/LineMDT/MDT.txt"), sequnceNumber);
			}
			else if (j >= 100 && j <= 999)
			{
				sequnceNumber = "0000" + j;
				File.WriteAllText(Server.MapPath("~/LineMDT/MDT.txt"), sequnceNumber);
			}
			else if (j >= 1000 && j <= 9999)
			{
				sequnceNumber = "000" + j;
				File.WriteAllText(Server.MapPath("~/LineMDT/MDT.txt"), sequnceNumber);
			}
			else if (j >= 10000 && j <= 99999)
			{
				sequnceNumber = "00" + j;
				File.WriteAllText(Server.MapPath("~/LineMDT/MDT.txt"), sequnceNumber);
			}
			else if (j >= 100000 && j <= 999999)
			{
				sequnceNumber = "0" + j;
				File.WriteAllText(Server.MapPath("~/LineMDT/MDT.txt"), sequnceNumber);
			}

		}
	}

	//Print button
	protected void printBtn_ServerClick(object sender, EventArgs e)
	{
		try
		{
			string fsnNumber = lblFsn.InnerText;
			string partNumber = lblKpart.InnerText;
			string desc = lbldesc.InnerText;
			string hmChk = lblLine.InnerText;
			string printerName = string.Empty;

			StringBuilder ZplBuilder = new StringBuilder();
			ZplBuilder.Append("^XA");
			ZplBuilder.Append("^CI0");
			ZplBuilder.Append("^FT30,50^A0N,32^FDFSN:^FS");
			ZplBuilder.Append("^FT165,50^A0N,32^FD" + fsnNumber + "^FS");
			ZplBuilder.Append("^FT30,150^A0N,32^FDPart No:^FS");
			ZplBuilder.Append("^FT165,150^A0N,32^FD" + partNumber + "^FS");
			ZplBuilder.Append("^FT30,250^A0N,32^FDDesc:^FS");
			ZplBuilder.Append("^FT165,250^A0N,32^FD" + desc + "^FS");
			ZplBuilder.Append("^FT30,340^A0N,34^FDLine:^FS");
			ZplBuilder.Append("^FT165,340^A0N,34^FD" + hmChk + "^FS");
			//ZplBuilder.Append("^FT330,340^A0N,34^FDProduct:^FS");
			//ZplBuilder.Append("^FT455,340^A0N,34^FD" + dr["Product"].ToString() + "^FS");
			ZplBuilder.Append("^FO400,5^");
			ZplBuilder.Append("^FO600,2^BY3,3.0,30^BQN,7,7^FD>;" + partNumber + " - " + fsnNumber + "^FS");
			//ZplBuilder.Append("^FO0,75^GB370,0,1^FS");
			//ZplBuilder.Append("^FO0,130^GB520,0,1^FS");
			//ZplBuilder.Append("^FO0,190^GB520,0,1^FS");
			//ZplBuilder.Append("^FO0,250^GB520,0,1^FS");
			//ZplBuilder.Append("^FO0,310^GB520,0,1^FS");
			ZplBuilder.Append("^XZ");

			StringBuilder ZplBuilderPrint = new StringBuilder();
			//string dd = GetZplCode(base64, i, 183);
			ZplBuilder.Append(ZplBuilder.ToString().Trim());

			string ZplString = ZplBuilder.ToString();

			MemoryStream lmemStream = new MemoryStream();

			StreamWriter lstreamWriter = new StreamWriter(lmemStream);
			lstreamWriter.Write(ZplString);
			lstreamWriter.Flush();
			lmemStream.Position = 0;

			byte[] byteArray = lmemStream.ToArray();

			IntPtr cpUnmanagedBytes = new IntPtr(0);
			int cnLength = byteArray.Length;
			cpUnmanagedBytes = Marshal.AllocCoTaskMem(cnLength);
			Marshal.Copy(byteArray, 0, cpUnmanagedBytes, cnLength);

			RawPrinterHelper.SendBytesToPrinter(printerName, cpUnmanagedBytes, cnLength);
			Marshal.FreeCoTaskMem(cpUnmanagedBytes);



		}
		catch (Exception exe)
		{

		}
	}

	public class RawPrinterHelper
	{
		// Structure and API declarions:
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public class DOCINFOA
		{
			[MarshalAs(UnmanagedType.LPStr)]
			public string pDocName;
			[MarshalAs(UnmanagedType.LPStr)]
			public string pOutputFile;
			[MarshalAs(UnmanagedType.LPStr)]
			public string pDataType;
		}
		[DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
		public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

		[DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
		public static extern bool ClosePrinter(IntPtr hPrinter);

		[DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
		public static extern bool StartDocPrinter(IntPtr hPrinter, int level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

		[DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
		public static extern bool EndDocPrinter(IntPtr hPrinter);

		[DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
		public static extern bool StartPagePrinter(IntPtr hPrinter);

		[DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
		public static extern bool EndPagePrinter(IntPtr hPrinter);

		[DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
		public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, int dwCount, out int dwWritten);

		// SendBytesToPrinter()
		// When the function is given a printer name and an unmanaged array
		// of bytes, the function sends those bytes to the print queue.
		// Returns true on success, false on failure.
		public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, int dwCount)
		{
			int dwError = 0, dwWritten = 0;
			IntPtr hPrinter = new IntPtr(0);
			DOCINFOA di = new DOCINFOA();
			bool bSuccess = false; // Assume failure unless you specifically succeed.
			di.pDocName = "My C#.NET RAW Document";
			di.pDataType = "RAW";

			// Open the printer.
			if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
			{
				if (StartDocPrinter(hPrinter, 1, di))
				{
					if (StartPagePrinter(hPrinter))
					{
						bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
						EndPagePrinter(hPrinter);
					}
					EndDocPrinter(hPrinter);
				}
				ClosePrinter(hPrinter);
			}

			if (bSuccess == false)
			{
				dwError = Marshal.GetLastWin32Error();
			}
			return bSuccess;
		}

		public static bool SendFileToPrinter(string szPrinterName, string szFileName)
		{
			FileStream fs = new FileStream(szFileName, FileMode.Open);
			BinaryReader br = new BinaryReader(fs);

			byte[] bytes = new Byte[fs.Length];
			bool bSuccess = false;
			IntPtr pUnmanagedBytes = new IntPtr(0);
			int nLength;

			nLength = Convert.ToInt32(fs.Length);
			bytes = br.ReadBytes(nLength);
			pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength);
			Marshal.Copy(bytes, 0, pUnmanagedBytes, nLength);
			bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, nLength);
			Marshal.FreeCoTaskMem(pUnmanagedBytes);
			return bSuccess;
		}
		public static bool SendStringToPrinter(string szPrinterName, string szString)
		{
			IntPtr pBytes;
			int dwCount;


			// How many characters are in the string?
			// Fix from Nicholas Piasecki:
			// dwCount = szString.Length;
			dwCount = (szString.Length + 1) * Marshal.SystemMaxDBCSCharSize;

			// Assume that the printer is expecting ANSI text, and then convert
			// the string to ANSI text.
			pBytes = Marshal.StringToCoTaskMemAnsi(szString);
			// Send the converted ANSI string to the printer.
			SendBytesToPrinter(szPrinterName, pBytes, dwCount);
			Marshal.FreeCoTaskMem(pBytes);
			return true;
		}
	}
}