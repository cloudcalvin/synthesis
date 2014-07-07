﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventor;

public class MotionLimits
{
    private Dictionary<ComponentOccurrence, bool> oldContactState = new Dictionary<ComponentOccurrence, bool>();
    private Dictionary<ComponentOccurrence, bool> oldVisibleState = new Dictionary<ComponentOccurrence, bool>();

    public void doIsolation(ComponentOccurrence occ, bool isolate)
    {
        if (occ.SubOccurrences.Count == 0)
        {
            if (isolate)
            {
                oldVisibleState[occ] = occ.Visible;
                occ.Visible = false;
            }
            else
            {
                occ.Visible = oldVisibleState[occ];
            }
        }
        else
        {
            foreach (ComponentOccurrence oc in occ.SubOccurrences)
            {
                doIsolation(oc, isolate);
            }
        }
    }

    public ComponentOccurrence getParent(ComponentOccurrence cO)
    {
        if (cO.ParentOccurrence != null)
        {
            return getParent(cO.ParentOccurrence);
        }
        else
        {
            return cO;
        }
    }

    public void doContactSetup(bool enable, params CustomRigidGroup[] groups)
    {
        if (enable)
        {
            oldContactState.Clear();
            oldVisibleState.Clear();
        }
        HashSet<AssemblyComponentDefinition> roots = new HashSet<AssemblyComponentDefinition>();
        foreach (CustomRigidGroup group in groups)
        {
            foreach (ComponentOccurrence cO in group.occurrences)
            {
                roots.Add(getParent(cO).Parent);
            }
        }
        foreach (AssemblyComponentDefinition cO in roots)
        {
            foreach (ComponentOccurrence cOo in cO.Occurrences)
            {
                doIsolation(cOo, enable);
            }
        }

        foreach (CustomRigidGroup group in groups)
        {
            foreach (ComponentOccurrence cO in group.occurrences)
            {
                if (enable)
                {
                    cO.Visible = true;
                    oldContactState[cO] = cO.ContactSet;
                    try
                    {
                        cO.ContactSet = true;
                    }
                    catch (Exception e) { }
                }
                else
                {
                    cO.Visible = oldVisibleState[cO];
                }
            }
        }
    }

    public static bool didCollide = false;
    public static void onCollision()
    {
        didCollide = true;
    }
}