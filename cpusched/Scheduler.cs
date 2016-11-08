using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpusched
{
    class Scheduler
    {
        public delegate Sched Algorithm(List<Process> processes);

        public static IDictionary<Algorithm, string> Names =  new Dictionary<Algorithm, string>()
        {
            {FirstComeFirstServe, "First Come First Serve"},
            {ShortestJobFirst, "Shortest Job First"},
            {RoundRobin, "Round Robin"},
        };

        public static Sched FirstComeFirstServe(List<Process> ps)
        {
            Comparison<Process> cmp;
            ps = ps.OrderBy(p => p.Arrival).ToList();
            var sched = new Sched();
            var t = 0;
            foreach (var p in ps)
            {
                sched.Add(Tuple.Create(p.Burst, p));
                t += p.Burst;
            }
            return sched;
        }

        // non-preemptive
        public static Sched ShortestJobFirst(List<Process> ps)
        {
            Comparison<Process> cmp;
            ps = ps.OrderBy(p => Tuple.Create(p.Arrival, p.Burst)).ToList();
            var sched = new Sched();
            var t = 0;
            foreach (var p in ps)
            {
                sched.Add(Tuple.Create(p.Burst, p));
                t += p.Burst;
            }
            return sched;
        }

        // pre-emptive SJF
        public static Sched ShortestRemainingTimeFirst(List<Process> ps)
        {
            // TODO:
            return new Sched();
        }

        public static Sched RoundRobin(List<Process> ps)
        {
            // TODO:
            return new Sched();
        }
    }
}
