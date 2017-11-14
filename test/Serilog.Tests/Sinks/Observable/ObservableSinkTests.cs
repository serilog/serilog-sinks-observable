﻿using System;
using System.Reactive.Linq;
using Xunit;
using Serilog.Tests.Support;

namespace Serilog.Tests.Sinks.Observable
{
    public class ObservableSinkTests
    {
        [Fact]
        public void EventsAreWrittenToObservers()
        {
            var eventSeen = false;

            using (var log = new LoggerConfiguration()
                .WriteTo.Observers(events => events
                    .Do(evt => { eventSeen = true; })
                    .Subscribe())
                .CreateLogger())
            {
                log.Write(Some.InformationEvent());
            }

            Assert.True(eventSeen);
        }
    }
}
