using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles_2._0
{
    internal class Articles2
    {
        static void Main(string[] args)
        {

            int numOfEdits = int.Parse(Console.ReadLine());

            List<Article> articleList = new List<Article>();

            for (int i = 0; i < numOfEdits; i++)
            {

                string[] cmdArgs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                Article articles = new Article(cmdArgs[0], cmdArgs[1], cmdArgs[2]);
                articleList.Add(articles);

            }

            string orderCmd = Console.ReadLine();

            switch (orderCmd)
            {

                case "title":

                    articleList = articleList.OrderByDescending(x => x.Title).ToList();

                    break;
                case "content":

                    articleList = articleList.OrderByDescending(x => x.Content).ToList();

                    break;
                case "author":

                    articleList = articleList.OrderByDescending(x => x.Author).ToList();

                    break;

            }

            foreach (Article article in articleList)
            {
                Console.WriteLine(article.ToString());
            }

        }

        class Article
        {
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }

            public string Title { get; private set; }
            public string Content { get; private set; }
            public string Author { get; private set; }

            //public void RenameArticle(string newTitle)
            //{
            //    Title = newTitle;
            //}

            //public void EditContent(string newContent)
            //{
            //    Content = newContent;
            //}

            //public void ChangeAuthor(string newAuthor)
            //{
            //    Author = newAuthor;
            //}

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }


        }

    }
}