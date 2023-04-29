using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }

        public User User { get; set; }
        public string name { get; set; }
        public string Email { get; set; }

        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremiun)
            {
                AddNotification(new Notification("Premiun", "O aluno já tem um asinatura ativa"));
                return;
            }
            else
            {
                Subscriptions.Add(subscription);
            }
        }

        public bool IsPremiun => Subscriptions.Any(x => !x.IsInactive);
    }
}