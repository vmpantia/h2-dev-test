namespace Questionaire.Web.Data.Stubs
{
    public class Stub
    {
        public static List<Question> Questions
        {
            get
            {
                return new List<Question>
                {
                    new Question
                    {
                        Number = 1,
                        Text = "You went to a party last night and when you\r\narrived to school the next day, everybody is\r\ntalking about something you didn’t do. What\r\nwill you do?\r\n",
                        Choices = new List<Choice> {
                            new Choice
                            {
                                Key = "A",
                                Value = "Avoid everything and go\r\nwith your friends\r\n",
                            },
                            new Choice
                            {
                                Key = "B",
                                Value = "Go and talk with the\r\nperson that started the\r\nrumors",
                            },
                            new Choice
                            {
                                Key = "C",
                                Value = "Go and talk with the\r\nteacher\r\n",
                            },
                        }
                    },
                    new Question
                    {
                        Number = 2,
                        Text = "What quality do you excel the most?",
                        Choices = new List<Choice> {
                            new Choice
                            {
                                Key = "A",
                                Value = "Empathy",
                            },
                            new Choice
                            {
                                Key = "B",
                                Value = "Curiosity",
                            },
                            new Choice
                            {
                                Key = "C",
                                Value = "Perseverance",
                            },
                        }
                    },
                    new Question
                    {
                        Number = 3,
                        Text = "You are walking down the street when you see\r\nan old lady trying to cross, what will you do?\r\n",
                        Choices = new List<Choice> {
                            new Choice
                            {
                                Key = "A",
                                Value = "Go and help her",
                            },
                            new Choice
                            {
                                Key = "B",
                                Value = "Go for a policeman and\r\nask him to help\r\n",
                            },
                            new Choice
                            {
                                Key = "C",
                                Value = "Keep walking ahead",
                            },
                        }
                    },
                    new Question
                    {
                        Number = 4,
                        Text = "You had a very difficult day at school, you will\r\nmaintain a ____ attitude",
                        Choices = new List<Choice> {
                            new Choice
                            {
                                Key = "A",
                                Value = "Depends on the situation",
                            },
                            new Choice
                            {
                                Key = "B",
                                Value = "Positive",
                            },
                            new Choice
                            {
                                Key = "C",
                                Value = "Negative",
                            },
                        }
                    },
                    new Question
                    {
                        Number = 5,
                        Text = "You are at a party and a friend of yours comes\r\nover and offers you a drink, what do you do?",
                        Choices = new List<Choice> {
                            new Choice
                            {
                                Key = "A",
                                Value = "Say no thanks",
                            },
                            new Choice
                            {
                                Key = "B",
                                Value = "Drink it until it is finished",
                            },
                            new Choice
                            {
                                Key = "C",
                                Value = "Ignore him and get angry at\r\nhim",
                            },
                        }
                    },
                    new Question
                    {
                        Number = 6,
                        Text = "You just started in a new school, you will... ",
                        Choices = new List<Choice> {
                            new Choice
                            {
                                Key = "A",
                                Value = "Go and talk with the\r\nperson next to you",
                            },
                            new Choice
                            {
                                Key = "B",
                                Value = "Wait until someone\r\ncomes over you",
                            },
                            new Choice
                            {
                                Key = "C",
                                Value = "Not talk to anyone\r\n",
                            },
                        }
                    },
                    new Question
                    {
                        Number = 7,
                        Text = "In a typical Friday, you would like to..",
                        Choices = new List<Choice> {
                            new Choice
                            {
                                Key = "A",
                                Value = "Go out with your close\r\nfriends to eat",
                            },
                            new Choice
                            {
                                Key = "B",
                                Value = "Go to a social club and\r\nmeet more people",
                            },
                            new Choice
                            {
                                Key = "C",
                                Value = "Invite one of your friends to\r\nyour house\r\n",
                            },
                        }
                    },
                    new Question
                    {
                        Number = 8,
                        Text = "Your relationship with your parents is..",
                        Choices = new List<Choice> {
                            new Choice
                            {
                                Key = "A",
                                Value = "I like both equally",
                            },
                            new Choice
                            {
                                Key = "B",
                                Value = "I like both equally ",
                            },
                            new Choice
                            {
                                Key = "C",
                                Value = "I like my Mom the most",
                            },
                        }
                    },
                };
            }
        }
    }
}
