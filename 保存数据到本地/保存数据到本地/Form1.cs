using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Microsoft.Win32;  // 引入注册表相关的命名空间
using System.Runtime.Caching;

namespace 保存数据到本地
{
    public partial class Form1 : Form
    {
        // 缓存文件路径
        private string cacheFilePath = "cache.json";

        public Form1()
        {
            InitializeComponent();
        }

        // 保存数据到文件
        private void save_Click(object sender, EventArgs e)
        {
            // 获取 TextBox 中的内容
            string textBoxContent = textBox1.Text;

            // 将 TextBox 内容序列化为 JSON 格式
            string jsonContent = JsonConvert.SerializeObject(textBoxContent);

            // 将 JSON 内容保存到文件
            File.WriteAllText(cacheFilePath, jsonContent);

            //MessageBox.Show("数据已保存！", "保存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 从文件获取数据并加载到 TextBox
        private void get_Click(object sender, EventArgs e)
        {
            if (File.Exists(cacheFilePath))
            {
                // 读取文件中的 JSON 内容
                string jsonContent = File.ReadAllText(cacheFilePath);

                // 反序列化 JSON 内容到 TextBox
                string restoredText = JsonConvert.DeserializeObject<string>(jsonContent);

                // 将读取的数据设置回 TextBox
                textBox1.Text = restoredText;

                //MessageBox.Show("数据已加载！", "加载成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("缓存文件不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //注册表保存
        // 注册表键名 (此处假设你将数据保存在软件的 "MyApp" 分支下)
        private string registryKeyPath = @"Software\MyApp";
        private void button1_Click(object sender, EventArgs e)
        {
            string textBoxContent = textBox1.Text;

            // 打开或创建注册表项
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryKeyPath))
            {
                if (key != null)
                {
                    // 将 TextBox 内容保存到注册表中
                    key.SetValue("TextBoxContent", textBoxContent);
                    //MessageBox.Show("数据已保存到注册表！", "保存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void get2_Click(object sender, EventArgs e)
        {
            // 打开注册表项
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryKeyPath))
            {
                if (key != null)
                {
                    // 从注册表中读取 TextBox 内容
                    object savedValue = key.GetValue("TextBoxContent");
                    if (savedValue != null)
                    {
                        // 设置 TextBox 的内容为读取到的数据
                        textBox1.Text = savedValue.ToString();
                        //MessageBox.Show("数据已从注册表加载！", "加载成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("注册表中没有保存的数据！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("注册表项不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // 使用MemoryCache来保存数据
        private static MemoryCache memoryCache = MemoryCache.Default;
        private void button2_Click(object sender, EventArgs e)
        {
            // 将TextBox中的数据保存到MemoryCache
            string key = "textBoxData";  // 设置缓存的键
            string value = textBox1.Text; // 获取TextBox中的内容

            // 使用Set方法保存数据，第二个参数是过期时间，这里设置为60分钟
            memoryCache.Set(key, value, DateTimeOffset.Now.AddMinutes(60));
            //MessageBox.Show("数据已保存到内存缓存！");
        }

        private void get3_Click(object sender, EventArgs e)
        {
            // 从MemoryCache中获取数据
            string key = "textBoxData";  // 假设键是固定的
            string cachedValue = memoryCache.Get(key) as string;  // 获取缓存数据

            if (!string.IsNullOrEmpty(cachedValue))
            {
                textBox1.Text = cachedValue; // 显示缓存中的数据
            }
            else
            {
                MessageBox.Show("没有找到缓存数据！");
            }
        }

        //多文件系统获取
        // 缓存文件路径
        private string cacheFilePath2 = "cache2.json";
        private void save4_Click(object sender, EventArgs e)
        {
            var textData = new Dictionary<string, string>
            {
                { "textBox1", textBox1.Text },
                { "textBox2", textBox2.Text }
            };

            // 序列化字典为 JSON
            string jsonContent = JsonConvert.SerializeObject(textData);

            // 将 JSON 内容保存到文件
            File.WriteAllText(cacheFilePath2, jsonContent);

            //MessageBox.Show("数据已保存！", "保存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void get4_Click(object sender, EventArgs e)
        {
            if (File.Exists(cacheFilePath2))
            {
                // 读取文件中的 JSON 内容
                string jsonContent = File.ReadAllText(cacheFilePath2);

                // 反序列化 JSON 内容到 Dictionary<string, string>
                var restoredData = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonContent);

                // 判断反序列化是否成功，并将数据设置回 TextBox
                if (restoredData != null)
                {
                    if (restoredData.ContainsKey("textBox1"))
                        textBox1.Text = restoredData["textBox1"];
                    if (restoredData.ContainsKey("textBox2"))
                        textBox2.Text = restoredData["textBox2"];

                    //MessageBox.Show("数据已加载！", "加载成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("加载数据失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("缓存文件不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //


    }
}
