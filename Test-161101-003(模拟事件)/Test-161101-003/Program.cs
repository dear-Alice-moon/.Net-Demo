using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test_161101_003
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  用委托实现的音乐播放器

            //MusicPlayer mp3 = new MusicPlayer();
            //mp3.AfterStartedPlay = () =>
            //{
            //    Console.WriteLine("加载歌词！！！");
            //    Console.WriteLine("停止动感背景！！！");
            //};

            //mp3.BeforeMusicStop = () =>
            //{
            //    Console.WriteLine("删除歌词！！！");
            //    Console.WriteLine("停止动感背景！！！");
            //};

            ////委托可以用=直接赋值，可以将以前“注册”的方法都覆盖掉。
            //mp3.AfterStartedPlay = null;
            //mp3.BeforeMusicStop = null;

            //mp3.StartPlay();
            //mp3.EndMusic();

            ////因为是用委托来实现的，所以在外部可以随意调用触发
            ////此时，不能将委托变成private,如果改成私有的，则也无法为委托变量赋值了。
            ////mp3.AfterStartedPlay();
            ////mp3.BeforeMusicStop();

            //Console.WriteLine("Ok");
            //Console.ReadKey();

            #endregion

            #region  用event事件来实现音乐播放器
            MusicPlayer mp3 = new MusicPlayer();
            mp3.AfterStartedPlay += new Action(mp3_AfterStartedPlay);
            mp3.BeforeMusicStop += new Action(mp3_BeforeMusicStop);

            //mp3.StartPlay();

            //mp3.EndMusic();

            //事件在外部不能直接调用
            //事件只能在定义事件的类的内部来触发
            //mp3.AfterStartedPlay();
            //mp3.BeforeMusicStop();


            Console.ReadKey();
            #endregion


        }

        static void mp3_AfterStartedPlay() 
        {
            Console.WriteLine("加载歌词。。。。。。");
        }

        static void mp3_BeforeMusicStop() 
        {
            Console.WriteLine("删除歌词。。。。。。");
        }


    }

    /// <summary>
    /// 音乐播放器类
    /// </summary>
    public class MusicPlayer 
    {
        ////做几个事件
        ////1、音乐开始播放后触发某个事件
        //public Action AfterStartedPlay;

        ////2、音乐停止播放之前触发某个事件
        //public Action BeforeMusicStop;

        //做几个事件
        //1、音乐开始播放后触发某个事件
        public event Action AfterStartedPlay;

        //2、音乐停止播放之前触发某个事件
        public event Action BeforeMusicStop;


        private void PlayMusic() 
        {
            Console.WriteLine("开始播放音乐............");
        }

        /// <summary>
        /// 按下[播放]按钮实现播放音乐
        /// </summary>
        public void StartPlay() 
        {
            PlayMusic();
            //当音乐开始播放后触发该事件
            if (AfterStartedPlay != null)
            {
                AfterStartedPlay();
            }
            Thread.Sleep(2000);
        }

        /// <summary>
        /// 音乐播放完毕！
        /// </summary>
        public void EndMusic() 
        {
            //在音乐播放结束之前
            if (BeforeMusicStop != null)
            {
                BeforeMusicStop();
            }

            Console.WriteLine("音乐播放完毕！");
        }


    }


}
