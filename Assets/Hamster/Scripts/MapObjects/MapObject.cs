﻿// Copyright 2017 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;
using System.Collections;

namespace Hamster.MapObjects {

  // General base-class for objects on the map.
  public class MapObject : MonoBehaviour {

    // By default, map objects don't do anything special when created or
    // on update, but map tiles can override this if needed.
    public virtual void Start() {
    }

    public virtual void Update() {
    }

    // Generic behavior for map objects.
    // When something hits them, they do stuff.
    void OnTriggerEnter(Collider collider) {
      MapObjectActivation(collider);
    }

    // Objects override this to define custom behavior when hit.
    protected virtual void MapObjectActivation(Collider collider) {
    }

    // Reset the MapObject back to its original state.
    public virtual void Reset() { }
  }
}
