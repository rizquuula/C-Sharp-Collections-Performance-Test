﻿using CollectionsPerformanceTest.Models;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsPerformanceTest.Business {
  class TweetsICollection : TweetsIterator {
    ICollection<object> _tweets; 
    internal TweetsICollection(ArrayList tweets)
      : base() {
      _tweets = tweets.ToArray();
    }

    internal List<object> GetTweets() {
      return null;
    }

    internal override void DoLoop() {
      foreach(object tweet in _tweets) {
        // Do Nothing
      }
    }
  }
}
