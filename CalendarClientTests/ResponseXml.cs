using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarClientTests
{
    class ResponseXml
    {
        public static string CalendarResponse = @"<?xml version='1.0' encoding='utf-16'?>
<ArrayOfEvent xmlns:xsd='http://www.w3.org/2001/XMLSchema' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'>
  <Event Id='3564'>
    <StartDate>2015-11-20T00:00:00</StartDate>
    <EndDate>2015-11-20T00:00:00</EndDate>
    <StartTime>09:30</StartTime>
    <EndTime />
    <Description>Consideration of Private Members' Bills. Proceedings will be interrupted at 11am for the Urgent Questions.</Description>
    <SortOrder>1</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Business</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='6053'>
    <StartDate>2015-11-20T00:00:00</StartDate>
    <EndDate>2015-11-20T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Regulation of Political Opinion Polling Bill [HL] - Committee stage - Committee of the Whole House</Description>
    <SortOrder>1</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Legislation</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='579'>
        <Name>Lord Foulkes of Cumnock</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata>
      <Metadata>
        <Url>http://services.parliament.uk/bills/2015-16/regulationofpoliticalopinionpolling.html</Url>
        <Description>Bill webpage</Description>
      </Metadata>
    </Metadata>
  </Event>
  <Event Id='4033'>
    <StartDate>2015-11-20T00:00:00</StartDate>
    <EndDate>2015-11-20T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Compulsory Emergency First Aid Education (State-funded Secondary Schools) Bill - 2nd reading (day 1)</Description>
    <SortOrder>2</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Legislation</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4003'>
        <Name>Teresa Pearce</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata>
      <Metadata>
        <Url>http://services.parliament.uk/bills/2015-16/compulsoryemergencyfirstaideducationstatefundedsecondaryschools.html</Url>
        <Description>Bill webpage</Description>
      </Metadata>
    </Metadata>
  </Event>
  <Event Id='5921'>
    <StartDate>2015-11-20T00:00:00</StartDate>
    <EndDate>2015-11-20T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Mesothelioma (Amendment) Bill [HL] - 2nd reading</Description>
    <SortOrder>2</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Legislation</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='738'>
        <Name>Lord Alton of Liverpool</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata>
      <Metadata>
        <Url>http://services.parliament.uk/bills/2015-16/mesotheliomaamendment.html</Url>
        <Description>Bill webpage</Description>
      </Metadata>
    </Metadata>
  </Event>
  <Event Id='5645'>
    <StartDate>2015-11-20T00:00:00</StartDate>
    <EndDate>2015-11-20T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Planning (Subterranean Development) Bill [HL] - 2nd reading</Description>
    <SortOrder>3</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Legislation</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='805'>
        <Name>Lord Dubs</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata>
      <Metadata>
        <Url>http://services.parliament.uk/bills/2015-16/planningsubterraneandevelopment.html</Url>
        <Description>Bill webpage</Description>
      </Metadata>
    </Metadata>
  </Event>
  <Event Id='6045'>
    <StartDate>2015-11-20T00:00:00</StartDate>
    <EndDate>2015-11-20T00:00:00</EndDate>
    <StartTime>11:00</StartTime>
    <EndTime />
    <Description>Negotiations for a new junior doctors’ contract </Description>
    <SortOrder>3</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Urgent question</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4038'>
        <Name>Heidi Alexander</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5646'>
    <StartDate>2015-11-20T00:00:00</StartDate>
    <EndDate>2015-11-20T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Direct Planning (Pilot) Bill [HL] - 2nd reading</Description>
    <SortOrder>4</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Legislation</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4202'>
        <Name>Lord Lexden</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata>
      <Metadata>
        <Url>http://services.parliament.uk/bills/2015-16/directplanningpilot.html</Url>
        <Description>Bill webpage</Description>
      </Metadata>
    </Metadata>
  </Event>
  <Event Id='6046'>
    <StartDate>2015-11-20T00:00:00</StartDate>
    <EndDate>2015-11-20T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Trans people in UK prisons</Description>
    <SortOrder>4</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Urgent question</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4436'>
        <Name>Cat Smith</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5552'>
    <StartDate>2015-11-20T00:00:00</StartDate>
    <EndDate>2015-11-20T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Adult skills budgets in Enfield</Description>
    <SortOrder>5</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Adjournment</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='166'>
        <Name>Joan Ryan</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='6059'>
    <StartDate>2015-11-20T00:00:00</StartDate>
    <EndDate>2015-11-20T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Junior doctor contracts</Description>
    <SortOrder>5</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Statement</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags>
      <Tag>
        <Description>Health</Description>
      </Tag>
    </Tags>
    <Members>
      <Member Id='127'>
        <Name>Lord Prior of Brampton</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='6060'>
    <StartDate>2015-11-20T00:00:00</StartDate>
    <EndDate>2015-11-20T00:00:00</EndDate>
    <StartTime>15:00</StartTime>
    <EndTime />
    <SortOrder>6</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Estimated rising time</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='4733'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime>11:00</StartTime>
    <EndTime />
    <Description>Lord Bruce of Bennachie and Baroness Rock will be introduced</Description>
    <SortOrder>1</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Introduction(s)</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5546'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime>09:30</StartTime>
    <EndTime />
    <Description>Energy and Climate Change, including Topical Questions</Description>
    <SortOrder>1</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Oral questions</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5768'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime>11:30</StartTime>
    <EndTime />
    <Description>Housing and Planning Bill</Description>
    <SortOrder>1</SortOrder>
    <Type>General Committee</Type>
    <House>Commons</House>
    <Category>Public Bill Committee</Category>
    <Location>Room 12, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5773'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime>13:30</StartTime>
    <EndTime />
    <Description>Male suicide and International Men's Day</Description>
    <SortOrder>1</SortOrder>
    <Type>Westminster Hall</Type>
    <House>Commons</House>
    <Category>Westminster Hall debate</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='1565'>
        <Name>Philip Davies</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5791'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime>09:30</StartTime>
    <EndTime />
    <Description>Thomas Crane
Chipping Warden and Edgcote Parish</Description>
    <SortOrder>1</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 5, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='233'>
      <Description>High Speed Rail (London-West Midlands) Bill</Description>
      <Inquiries>
        <Inquiry Id='1732'>
          <Description>High Speed Rail (London-West Midlands) Bill</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='6715'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime>10:00</StartTime>
    <EndTime />
    <Description>(at 10:10 AM) 
Mr Guy Bransby, Lead Director, JLL
M Richard Lemon, Associate Director, CBRE
Mr Adrian Penfold, Head of Planning, British Land</Description>
    <SortOrder>1</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Lords</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 2, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='258'>
      <Description>National Policy for the Built Environment Committee</Description>
      <Inquiries>
        <Inquiry Id='2191'>
          <Description>Built Environment</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5374'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Violence and dishonesty convictions of serving police officers in England and Wales</Description>
    <SortOrder>2</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Oral questions</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4197'>
        <Name>Baroness Doocey</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5631'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Leader of the House</Description>
    <SortOrder>2</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Business Statement</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5769'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime>11:30</StartTime>
    <EndTime />
    <Description>Draft International Fund for Agricultural Development (Tenth Replenishment) Order 2015</Description>
    <SortOrder>2</SortOrder>
    <Type>General Committee</Type>
    <House>Commons</House>
    <Category>Third Delegated Legislation Committee </Category>
    <Location>Room 9, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5864'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime>09:45</StartTime>
    <EndTime />
    <Description>Tim Loughton MP, former Parliamentary Under Secretary of State for Children and Families, Department of Education 
Rt Hon Mr Oliver Letwin MP, Chancellor of the Duchy of Lancaster </Description>
    <SortOrder>2</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>The Grimond Room, Portcullis House</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='265'>
      <Description>Public Administration and Constitutional Affairs</Description>
      <Inquiries>
        <Inquiry Id='2313'>
          <Description>Kids Company</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='7284'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime>10:00</StartTime>
    <EndTime />
    <Description>(at 10:05 AM) 
Rt Hon. David Lidington  MP, Minister for Europe</Description>
    <SortOrder>2</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Lords</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 1, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='269'>
      <Description>EU External Affairs Sub-Committee</Description>
      <Inquiries>
        <Inquiry Id='2288'>
          <Description>Strategic Review of the EU’s foreign and security policy</Description>
          <SortOrder>2</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5375'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Foreign and Commonwealth Office funding</Description>
    <SortOrder>3</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Oral questions</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags>
      <Tag>
        <Description>Economic affairs</Description>
      </Tag>
      <Tag>
        <Description>World</Description>
      </Tag>
    </Tags>
    <Members>
      <Member Id='4331'>
        <Name>Baroness Helic</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5883'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime>11:30</StartTime>
    <EndTime />
    <Description>Universal Credit (Work Allowance) Amendment Regulations 2015 (S.I., 2015, No. 1649)</Description>
    <SortOrder>3</SortOrder>
    <Type>General Committee</Type>
    <House>Commons</House>
    <Category>First Delegated Legislation Committee </Category>
    <Location>Room 11, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5959'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Northern Ireland political agreement </Description>
    <SortOrder>3</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Ministerial statement</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='1500'>
        <Name>Theresa Villiers</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5376'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Risks posed to passenger aircraft by drones</Description>
    <SortOrder>4</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Oral questions</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags>
      <Tag>
        <Description>Transport</Description>
      </Tag>
    </Tags>
    <Members>
      <Member Id='2603'>
        <Name>Lord Glentoran</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5770'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime>14:00</StartTime>
    <EndTime />
    <Description>Housing and Planning Bill</Description>
    <SortOrder>4</SortOrder>
    <Type>General Committee</Type>
    <House>Commons</House>
    <Category>Public Bill Committee</Category>
    <Location>Room 12, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='6018'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Northern Ireland (Welfare Reform) Bill - 1st reading</Description>
    <SortOrder>4</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Legislation</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='1500'>
        <Name>Theresa Villiers</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata>
      <Metadata>
        <Url>http://services.parliament.uk/bills/2015-16/northernirelandwelfarereform.html</Url>
        <Description>Bill webpage</Description>
      </Metadata>
    </Metadata>
  </Event>
  <Event Id='5669'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>(i) Preparations for the Paris climate change conference (ii) A new cancer strategy</Description>
    <SortOrder>5</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Backbench Business</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5914'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>The government's manifesto commitment of achieving full employment in Britain</Description>
    <SortOrder>5</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Oral questions</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags>
      <Tag>
        <Description>Home affairs</Description>
      </Tag>
    </Tags>
    <Members>
      <Member Id='2097'>
        <Name>Baroness Seccombe</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5551'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Mesothelioma compensation for military veterans</Description>
    <SortOrder>6</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Adjournment</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4431'>
        <Name>David Mackintosh</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5999'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Northern Ireland Political Agreement</Description>
    <SortOrder>6</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Statement</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags>
      <Tag>
        <Description>Northern Ireland</Description>
      </Tag>
    </Tags>
    <Members>
      <Member Id='4534'>
        <Name>Lord Dunlop</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5627'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Role of trade unions in a democracy and their contribution to the general economic wellbeing of the nation
</Description>
    <SortOrder>7</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Debate</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags>
      <Tag>
        <Description>Economic affairs</Description>
      </Tag>
    </Tags>
    <Members>
      <Member Id='579'>
        <Name>Lord Foulkes of Cumnock</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5758'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Exclusion of drugs in sport</Description>
    <SortOrder>8</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Short debate</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags>
      <Tag>
        <Description>Culture media and sport</Description>
      </Tag>
    </Tags>
    <Members>
      <Member Id='3453'>
        <Name>Lord Addington</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5809'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Sale of UK assets to foreign ownership</Description>
    <SortOrder>9</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Debate</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags>
      <Tag>
        <Description>Economic affairs</Description>
      </Tag>
    </Tags>
    <Members>
      <Member Id='2648'>
        <Name>Viscount Hanworth</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5741'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Making Government international development policies more effective
</Description>
    <SortOrder>10</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Short debate</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags>
      <Tag>
        <Description>World</Description>
      </Tag>
    </Tags>
    <Members>
      <Member Id='2109'>
        <Name>The Earl of Sandwich</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5984'>
    <StartDate>2015-11-19T00:00:00</StartDate>
    <EndDate>2015-11-19T00:00:00</EndDate>
    <StartTime>20:00</StartTime>
    <EndTime />
    <SortOrder>11</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Estimated rising time</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5544'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>11:30</StartTime>
    <EndTime />
    <Description>Wales, including Topical Questions</Description>
    <SortOrder>1</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Oral questions</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5599'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>09:30</StartTime>
    <EndTime />
    <Description>Giles Peaker, Chair, Housing Law Practitioners Association
Paul Gray CB, Chair, Social Security Advisory Committee
Paul Howarth, Director, Welfare Reform Club
Dr Peter Kenway, Director, New Policy Institute
Rachael Badger, Head of Policy Research, Citizens Advice
David Holmes CBE, Chief Executive, Family Action
Francis McGee, Director of External Affairs, Stepchange Debt Charity
Joanna Kennedy, Chief Executive, Zacchaeus 2000 Trust</Description>
    <SortOrder>1</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>The Wilson Room, Portcullis House</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='57'>
      <Description>Work and Pensions</Description>
      <Inquiries>
        <Inquiry Id='2375'>
          <Description>Local welfare safety net</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5752'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>09:30</StartTime>
    <EndTime>11:00</EndTime>
    <Description>Women and low pay</Description>
    <SortOrder>1</SortOrder>
    <Type>Westminster Hall</Type>
    <House>Commons</House>
    <Category>Westminster Hall debate</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4389'>
        <Name>Ruth Cadbury</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5767'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>14:30</StartTime>
    <EndTime />
    <Description>Draft Exclusivity Terms in Zero Hours Contracts (Redress) Regulations 2015</Description>
    <SortOrder>1</SortOrder>
    <Type>General Committee</Type>
    <House>Commons</House>
    <Category>Second Delegated Legislation Committee </Category>
    <Location>Room 9, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5833'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>15:00</StartTime>
    <EndTime />
    <Description>.</Description>
    <SortOrder>1</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Royal Assent</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='7712'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>10:00</StartTime>
    <EndTime />
    <Description />
    <SortOrder>1</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Lords</House>
    <Category>Private Meeting</Category>
    <Location>Room 4, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='270'>
      <Description>EU Financial Affairs Sub-Committee</Description>
      <Inquiries />
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5337'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Justice services in England and Wales</Description>
    <SortOrder>2</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Oral questions</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags>
      <Tag>
        <Description>Home affairs</Description>
      </Tag>
    </Tags>
    <Members>
      <Member Id='4182'>
        <Name>Lord Blair of Boughton</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5545'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>12:00</StartTime>
    <EndTime />
    <SortOrder>2</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Prime Minister's Question Time</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5707'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>09:30</StartTime>
    <EndTime />
    <Description>Humphrey Morrison, Head of Legislation, Ministry of Defence
Paula Hothersall, Head People Secretariat, Policy for Service Justice, Service Complaints, Inclusion and Diversity, Ministry of Defence
Commodore Andrei Spence, Head of Naval Legal Services, Royal Navy
Brigadier John Donnelly CBE, Director Personnel Services, Army
Group Captain Mark Heffron, Royal Air Force
Andrew Cayley CMG QC, Director of Service Prosecutions, Service Prosecution Authority
Mr Phil Salt, Chief Fire Officer, Defence Fire Risk Management Organisation</Description>
    <SortOrder>2</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 16, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='276'>
      <Description>Armed Forces Bill</Description>
      <Inquiries>
        <Inquiry Id='2428'>
          <Description>Armed Forces Bill 2015-16</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5753'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>11:00</StartTime>
    <EndTime>11:30</EndTime>
    <Description>Road infrastructure in Shropshire</Description>
    <SortOrder>2</SortOrder>
    <Type>Westminster Hall</Type>
    <House>Commons</House>
    <Category>Westminster Hall debate</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='1566'>
        <Name>Daniel Kawczynski</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='7417'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>10:15</StartTime>
    <EndTime />
    <Description>(at 10:30 AM) 
Mr Alun Evans, Former Director of the Scotland Office
(at 11:15 AM) 
Professor Philip Booth, Institute of Economic Affiars</Description>
    <SortOrder>2</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Lords</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 1, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='66'>
      <Description>Constitution Committee</Description>
      <Inquiries>
        <Inquiry Id='2287'>
          <Description>The Union and devolution</Description>
          <SortOrder>2</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5338'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Equal application of fundamental rights in the UK</Description>
    <SortOrder>3</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Oral questions</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags>
      <Tag>
        <Description>Home affairs</Description>
      </Tag>
    </Tags>
    <Members>
      <Member Id='4202'>
        <Name>Lord Lexden</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5754'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>14:30</StartTime>
    <EndTime>16:00</EndTime>
    <Description>Personal injury fraud</Description>
    <SortOrder>3</SortOrder>
    <Type>Westminster Hall</Type>
    <House>Commons</House>
    <Category>Westminster Hall debate</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4028'>
        <Name>Karl McCartney</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5789'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>09:30</StartTime>
    <EndTime />
    <Description>Caroline Owen-Thomas trading as 'Weights and Measures Fitness Studio'
John Henderson
Jonathan and Suzanne King
Ronald Drackford
John Henry and Victoria Walker
Arezo Jounus
The Lionel Abel-Smith Trust
The Dunsmore Village Hall Association
Peter Harris
Catharine Harris
Vanessa Havard
Nicholas and Victoria Bartman
The National Trust
The Ernest Cook Trust
John and Michael Woodford
The Lord Carrington's 1963 Settlement (1 &amp; 2 Funds)
Antony Pearce
Lord N C J Rothschild, Waddesdon Estate
Stoke Mandeville Parish Council
Stoke Mandeville Action Group
Michael, Julia, Paul and Ruth Gaisford
John Robert Jakobi of Stoke House
John Allen
Petition of the late Vincent Nolan and Sheelagh Nolan
David Starr
John and Christine Cooper
John Vince [Para 50 of petition only]
The Tenants of Layby Farm Business Park
Paul Walter
Amania Clark 
Gordon Avery &amp; Others</Description>
    <SortOrder>3</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 5, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='233'>
      <Description>High Speed Rail (London-West Midlands) Bill</Description>
      <Inquiries>
        <Inquiry Id='1732'>
          <Description>High Speed Rail (London-West Midlands) Bill</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5923'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>The arrest of a former member of the Parachute Regiment on duty in Londonderry on 30 January 1972</Description>
    <SortOrder>3</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Urgent question</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='47'>
        <Name>Sir Gerald Howarth</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='6646'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>10:30</StartTime>
    <EndTime />
    <Description />
    <SortOrder>3</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Lords</House>
    <Category>Private Meeting</Category>
    <Location>Room 3, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='271'>
      <Description>EU Home Affairs Sub-Committee</Description>
      <Inquiries />
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5340'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Support given to Turkey since beginning of Middle East immigration crisis</Description>
    <SortOrder>4</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Oral questions</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags>
      <Tag>
        <Description>World</Description>
      </Tag>
    </Tags>
    <Members>
      <Member Id='648'>
        <Name>Lord Maginnis of Drumglass</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5755'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>16:00</StartTime>
    <EndTime>16:30</EndTime>
    <Description>Restoration of electrical shore supplies to nuclear-powered submarines</Description>
    <SortOrder>4</SortOrder>
    <Type>Westminster Hall</Type>
    <House>Commons</House>
    <Category>Westminster Hall debate</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4371'>
        <Name>Brendan O'Hara</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5772'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>09:45</StartTime>
    <EndTime />
    <Description>Professor Damian Chalmers, European Union Law, London School of Economics (via video link)
Professor Sir Alan Dashwood QC, Emeritus Professor of European Law and Fellow of Sidney Sussex College, Cambridge
Martin Howe QC
Professor Sir Francis Jacobs KCMG QC, President of the King's College London Centre for European Law</Description>
    <SortOrder>4</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>The Thatcher Room, Portcullis House</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='18'>
      <Description>European Scrutiny</Description>
      <Inquiries>
        <Inquiry Id='2323'>
          <Description>UK Government's renegotiation of EU membership: parliamentary sovereignty and scrutiny</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5965'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Speed Limits on Roads (Devolved Powers) Bill - 1st reading</Description>
    <SortOrder>4</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Legislation</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4496'>
        <Name>Scott Mann</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata>
      <Metadata>
        <Url>http://services.parliament.uk/bills/2015-16/speedlimitsonroadsdevolvedpowers.html</Url>
        <Description>Bill webpage</Description>
      </Metadata>
    </Metadata>
  </Event>
  <Event Id='7047'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>10:30</StartTime>
    <EndTime />
    <Description />
    <SortOrder>4</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Lords</House>
    <Category>Private Meeting</Category>
    <Location>Room 2, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='268'>
      <Description>EU Energy and Environment Sub-Committee</Description>
      <Inquiries />
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5668'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>(i) Government's record on the economy (ii) Further education</Description>
    <SortOrder>5</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Opposition Day Debate</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5756'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>16:30</StartTime>
    <EndTime>17:30</EndTime>
    <Description>Consular assistance for families of people who die abroad</Description>
    <SortOrder>5</SortOrder>
    <Type>Westminster Hall</Type>
    <House>Commons</House>
    <Category>Westminster Hall debate</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4437'>
        <Name>Anne McLaughlin</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5762'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>13:10</StartTime>
    <EndTime />
    <Description>Sara Ogilvie, Policy Officer, Liberty
Mark Lancaster MP, Parliamentary Under Secretary of State and Minister for Defence Personnel and Veterans, Ministry of Defence
General Sir Nick Carter KCB CBE DSO ADC Gen, Chief of the General Staff, Army</Description>
    <SortOrder>5</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 16, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='276'>
      <Description>Armed Forces Bill</Description>
      <Inquiries>
        <Inquiry Id='2428'>
          <Description>Armed Forces Bill 2015-16</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5884'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>The availability of emergency services in Central London and steps being taken to reinforce them in the light of the attacks in Paris on 13 November</Description>
    <SortOrder>5</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Oral questions</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags>
      <Tag>
        <Description>Defence</Description>
      </Tag>
    </Tags>
    <Members>
      <Member Id='2671'>
        <Name>Lord Harris of Haringey</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='7143'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>10:30</StartTime>
    <EndTime />
    <Description>(at 10:35 AM) 
Professor Baroness Alison Wolf of Dulwich, Author of the Review of Vocational Education - the Wolf Report
(at 11:35 AM) 
Professor Anne Green, Warwick Institute for Employment Research
Professor Sandra McNally, Director, LSE Centre for Vocational Education Research
Dr Stefan Speckesser, Chief Economist, Institute for Employment Studies</Description>
    <SortOrder>5</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Lords</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 4A, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='257'>
      <Description>Social Mobility Committee</Description>
      <Inquiries>
        <Inquiry Id='2193'>
          <Description>Social Mobility</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5550'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Pay of employees of the Department for Work and Pensions</Description>
    <SortOrder>6</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Adjournment</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4463'>
        <Name>Chris Stephens</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5641'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>European Union Referendum Bill - Report stage (day 1)</Description>
    <SortOrder>6</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Legislation</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='3474'>
        <Name>Baroness Anelay of St Johns</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata>
      <Metadata>
        <Url>http://services.parliament.uk/bills/2015-16/europeanunionreferendum.html</Url>
        <Description>Bill webpage</Description>
      </Metadata>
    </Metadata>
  </Event>
  <Event Id='5790'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>14:00</StartTime>
    <EndTime />
    <Description>As for morning session, unless already heard.</Description>
    <SortOrder>6</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 5, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='233'>
      <Description>High Speed Rail (London-West Midlands) Bill</Description>
      <Inquiries>
        <Inquiry Id='1732'>
          <Description>High Speed Rail (London-West Midlands) Bill</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5856'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>14:15</StartTime>
    <EndTime />
    <Description>Kathryn Geels, Programme Manager for 'Destination Local', Nesta
Ashley Highfield, Chief Executive, Johnston Press
David Holdsworth, Controller, English Regions, BBC
Joe Godwin, Director, BBC Birmingham  </Description>
    <SortOrder>7</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>The Grimond Room, Portcullis House</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='8'>
      <Description>Culture, Media and Sport</Description>
      <Inquiries>
        <Inquiry Id='2282'>
          <Description>BBC Charter Review</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5924'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Arrest of a former member of the Parachute Regiment on duty in Londonderry on the 30th January 1972</Description>
    <SortOrder>7</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Statement</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4534'>
        <Name>Lord Dunlop</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5743'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Improving stroke services, care and support, and updating the National Stroke Strategy</Description>
    <SortOrder>8</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Short debate</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4157'>
        <Name>Baroness Wheeler</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5858'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>14:15</StartTime>
    <EndTime />
    <Description>John Mills, Chairman, JML Group
Steve McQuillan, Chief Executive, Avingtrans plc
 Mike Cherry, Policy Director, Federation for Small Businesses
Carolyn Frank, Representative from Libby Butler Jewellers
Hugh Bearryman, Representative from TIGHTEN UP
Lars Andersen, Representative from Mynametags.com and Arty Lobster</Description>
    <SortOrder>8</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>The Wilson Room, Portcullis House</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='54'>
      <Description>Treasury</Description>
      <Inquiries>
        <Inquiry Id='2401'>
          <Description>The economic and financial costs and benefits of UK's EU membership</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5719'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>14:30</StartTime>
    <EndTime />
    <Description>Phillip Rutnam, Permanent Secretary, Department for Transport
John Kingman, Second Permanent Secretary, HM Treasury
Mark Russell, Chief Executive, Shareholder Executive, 
Roger Lowe, Director, Portfolio, Shareholder Executive </Description>
    <SortOrder>9</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 15, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='43'>
      <Description>Public Accounts</Description>
      <Inquiries>
        <Inquiry Id='2442'>
          <Description>Sale of Eurostar</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5972'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Finance Bill - Royal Assent</Description>
    <SortOrder>9</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Legislation</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4536'>
        <Name>Lord O'Neill of Gatley</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata>
      <Metadata>
        <Url>http://services.parliament.uk/bills/2015-16/finance.html</Url>
        <Description>Bill webpage</Description>
      </Metadata>
    </Metadata>
  </Event>
  <Event Id='5852'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>15:00</StartTime>
    <EndTime />
    <Description>Jo Dipple, Chief Executive, UK Music
Brian Coane, Chair, IPA Scotland
Amanda Nevill, Chief Executive Officer, British Film Institute
Ed Vaizey MP, Minister of State for Culture and the Digital Economy, Department for Culture, Media and Sport and Business Innovations and Skills
Baroness Neville-Rolfe DBE CMG, Parliamentary Under-Secretary of State and Minister for Intellectual Property, Department for Culture, Media and Sport and Business, Innovation and Skills</Description>
    <SortOrder>10</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 8, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='48'>
      <Description>Scottish Affairs</Description>
      <Inquiries>
        <Inquiry Id='2230'>
          <Description>Creative Industries in Scotland</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5925'>
    <StartDate>2015-11-18T00:00:00</StartDate>
    <EndDate>2015-11-18T00:00:00</EndDate>
    <StartTime>22:00</StartTime>
    <EndTime />
    <SortOrder>10</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Estimated rising time</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='4732'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>14:30</StartTime>
    <EndTime />
    <Description>Lord Porter of Spalding and Lord Shinkwin will be introduced</Description>
    <SortOrder>1</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Introduction(s)</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5420'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>11:30</StartTime>
    <EndTime />
    <Description>Health, including Topical Questions</Description>
    <SortOrder>1</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Oral questions</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5640'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Education and Adoption Bill - Committee stage (day 3) - Grand Committee</Description>
    <SortOrder>1</SortOrder>
    <Type>Grand Committee</Type>
    <House>Lords</House>
    <Category>Legislation</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4270'>
        <Name>Lord Nash</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata>
      <Metadata>
        <Url>http://services.parliament.uk/bills/2015-16/educationandadoption.html</Url>
        <Description>Bill webpage</Description>
      </Metadata>
    </Metadata>
  </Event>
  <Event Id='5747'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>09:30</StartTime>
    <EndTime>11:00</EndTime>
    <Description>Future of the reserve forces</Description>
    <SortOrder>1</SortOrder>
    <Type>Westminster Hall</Type>
    <House>Commons</House>
    <Category>Westminster Hall debate</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='1537'>
        <Name>Mr Philip Hollobone</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5763'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>09:25</StartTime>
    <EndTime />
    <Description>Housing and Planning Bill</Description>
    <SortOrder>1</SortOrder>
    <Type>General Committee</Type>
    <House>Commons</House>
    <Category>Public Bill Committee</Category>
    <Location>The Boothroyd Room, Portcullis House</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5855'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>09:15</StartTime>
    <EndTime />
    <Description>Professor Simon Gaskell, Chair of Universities UK quality assessment task and finish group and Treasurer, Universities UK
Alistair Sim, Director, Universities Scotland
Katie Akerman, Director of Quality and Standards, University of Chichester
Professor Colin Riordan, Vice Chancellor, Cardiff University
Professor Graham Virgo, Pro Vice Chancellor for Education, Cambridge University
Professor Belinda Tynan, Pro Vice Chancellor (learning and teaching), Open University
Professor Neil Ward, Pro Vice Chancellor-Academic, University of East Anglia</Description>
    <SortOrder>1</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 6, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='3'>
      <Description>Business, Innovation and Skills</Description>
      <Inquiries>
        <Inquiry Id='2373'>
          <Description>Assessing quality in Higher Education</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='6835'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>10:30</StartTime>
    <EndTime />
    <Description>(at 11:00 AM) 
Mr Marco Biagi MSP, Minister for Local Government and Community Empowerment, Scottish Government</Description>
    <SortOrder>1</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Lords</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 3, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='273'>
      <Description>EU Justice Sub-Committee</Description>
      <Inquiries>
        <Inquiry Id='2421'>
          <Description>Potential impact of repealing the Human Rights Act on EU Law</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5277'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Protecting those not charged with any offence from being named as under investigation
</Description>
    <SortOrder>2</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Oral questions</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags>
      <Tag>
        <Description>Home affairs</Description>
      </Tag>
    </Tags>
    <Members>
      <Member Id='315'>
        <Name>Lord Fowler</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5748'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>11:00</StartTime>
    <EndTime>11:30</EndTime>
    <Description>Junctions 12 to 14 of the M56 motorway</Description>
    <SortOrder>2</SortOrder>
    <Type>Westminster Hall</Type>
    <House>Commons</House>
    <Category>Westminster Hall debate</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4081'>
        <Name>Graham Evans</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5764'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>09:30</StartTime>
    <EndTime />
    <Description>Immigration Bill</Description>
    <SortOrder>2</SortOrder>
    <Type>General Committee</Type>
    <House>Commons</House>
    <Category>Public Bill Committee</Category>
    <Location>Room 14, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5787'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>09:30</StartTime>
    <EndTime />
    <Description>Robert Lewis
Springfield Farming Limited
James King
The Wood Lane Residents Association
Peter Watts
Paul and Judith Rodwell
Gregory Porter
Brian True-May
Maureen True-May
Brian Reeds
Jack Fuller
Trevor Johnson
Kathy and Phil Groves
Martin Bull
Captain Walker
Alan and Cheryl Myles
The Parochial Church Council of the Ecclesiastical Parish of St Mary the Virgin
Wendover Choral Society
Wendover Music
The Wendover University of the Third Age (U3A
William, Bridget and Ruth Avery
Patrick Fell and Julia Fish
Sheila Rankin
Mr A E Mogford 
Philip and Alison Doggett
Wycombe District Council
Bradenham Parish Council
West Wycombe Parish Council
Princes Risborough Town Council
Wolf-Rudiger Feiler
Linda Ward
Christine Holland
Linda Aspey
Emma and Lewis Johnson
Aylesbury Town Council
Coldharbour Parish Council
Steven Lambert
Anne Keleny</Description>
    <SortOrder>2</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 5, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='233'>
      <Description>High Speed Rail (London-West Midlands) Bill</Description>
      <Inquiries>
        <Inquiry Id='1732'>
          <Description>High Speed Rail (London-West Midlands) Bill</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5888'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>G20 and the Paris attacks</Description>
    <SortOrder>2</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Ministerial statement</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='1467'>
        <Name>Mr David Cameron</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5894'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>19:30</StartTime>
    <EndTime />
    <SortOrder>2</SortOrder>
    <Type>Grand Committee</Type>
    <House>Lords</House>
    <Category>Estimated rising time</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='6793'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>10:30</StartTime>
    <EndTime />
    <Description>(at 10:40 AM) 
Professor Sir Mark Walport FMedSci FRS, Government Chief Scientific Adviser, Government Office for Science</Description>
    <SortOrder>2</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Lords</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 4A, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='108'>
      <Description>Science and Technology Committee (Lords)</Description>
      <Inquiries>
        <Inquiry Id='2486'>
          <Description>Government Chief Scientific Adviser</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5278'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>How local authorities disburse money previously disbursed from the Independent Living Fund to enable disabled people to live independently
</Description>
    <SortOrder>3</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Oral questions</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags>
      <Tag>
        <Description>Health</Description>
      </Tag>
    </Tags>
    <Members>
      <Member Id='3831'>
        <Name>Baroness Campbell of Surbiton</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5749'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>14:30</StartTime>
    <EndTime>16:00</EndTime>
    <Description>Government policy on guaranteed income for retirees</Description>
    <SortOrder>3</SortOrder>
    <Type>Westminster Hall</Type>
    <House>Commons</House>
    <Category>Westminster Hall debate</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4390'>
        <Name>Ian Blackford</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5766'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>14:30</StartTime>
    <EndTime />
    <Description>European Union Documents No. 8344/15 and Addendum, Commission Communication: Reviewing the decision-making process on genetically modified organisms (GMOs); and No. 8356/15, Proposal for a Regulation amending Regulation (EC) No. 1829/2003 as regards the possibility for Member States to restrict or prohibit the use of genetically modified food or feed on their territory.</Description>
    <SortOrder>3</SortOrder>
    <Type>General Committee</Type>
    <House>Commons</House>
    <Category>European Committee A</Category>
    <Location>Room 10, Palace of Westminster </Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5807'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>09:30</StartTime>
    <EndTime />
    <Description>Richard Twinn, Policy Advisor, UK Green Building Council
Steve Cole, Policy Leader, National Housing Federation
Councillor Peter Fleming, Leader of Sevenoaks District Council and Member of the LGA Environment, Economy, Housing and Transport Board
Joanne Wade, Director, Association for the Conservation of Energy
Dave Princep, Environmental Health Consultant, Residential Landlords Association,
Lawrence Slade, CEO, Energy UK
Stephen Huller, Head of Commercial, Certinergy
Holly Jago, Corporate Affairs Manager, Calor Gas
Isaac Occhipinti, Head of External Affairs, Energy and Utilities Alliance</Description>
    <SortOrder>3</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 19, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='15'>
      <Description>Energy and Climate Change</Description>
      <Inquiries>
        <Inquiry Id='2360'>
          <Description>Home energy efficiency and demand reduction</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5908'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>House of Lords (Parliamentary Standards Etc) Bill - 1st reading</Description>
    <SortOrder>3</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Legislation</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='345'>
        <Name>Sir Edward Leigh</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata>
      <Metadata>
        <Url>http://services.parliament.uk/bills/2015-16/houseoflordsparliamentarystandardsetc.html</Url>
        <Description>Bill webpage</Description>
      </Metadata>
    </Metadata>
  </Event>
  <Event Id='7196'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>12:00</StartTime>
    <EndTime />
    <Description />
    <SortOrder>3</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Lords</House>
    <Category>Private Meeting</Category>
    <Location>Archbishops' Room, Millbank House</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='71'>
      <Description>European Union Committee</Description>
      <Inquiries />
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5279'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Raising human rights issues at the forthcoming Commonwealth Heads of Government meeting in Malta
</Description>
    <SortOrder>4</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Oral questions</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags>
      <Tag>
        <Description>Home affairs</Description>
      </Tag>
    </Tags>
    <Members>
      <Member Id='4218'>
        <Name>Baroness Berridge</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5682'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Cities and Local Government Devolution Bill [HL] - Committee stage (day 2) - Committee of the whole House</Description>
    <SortOrder>4</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Legislation</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='1578'>
        <Name>Greg Clark</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata>
      <Metadata>
        <Url>http://services.parliament.uk/bills/2015-16/citiesandlocalgovernmentdevolution.html</Url>
        <Description>Bill webpage</Description>
      </Metadata>
    </Metadata>
  </Event>
  <Event Id='5750'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>16:00</StartTime>
    <EndTime>16:30</EndTime>
    <Description>Court charges and access to justice</Description>
    <SortOrder>4</SortOrder>
    <Type>Westminster Hall</Type>
    <House>Commons</House>
    <Category>Westminster Hall debate</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4518'>
        <Name>Tulip Siddiq</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5859'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>09:45</StartTime>
    <EndTime />
    <Description>Rosalind Bragg, Director, Maternity Action
Rebecca Hilsenrath, Chief Executive, Equality and Human Rights Commission
Sybille Raphael, Advice Team Leader, Working Families
Emma Wilkinson, Senior Employment Expert, Citizens Advice
Kate Booth, Partner, Eaton Smith LLP
Sally Brett, Senior Policy Officer, Trade Union Congress
Stephen Cavalier, Chief Executive, Thompsons Solicitors
Shantha David, Legal Officer, Unison
Michael Mealing, Chair, Employment Policy Unit, Federation of Small Businesses
James Potts, Legal Services Solicitor, Peninsula Business Services Ltd</Description>
    <SortOrder>4</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 16, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='26'>
      <Description>Justice</Description>
      <Inquiries>
        <Inquiry Id='2269'>
          <Description>Court fees and charges</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='6699'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>14:00</StartTime>
    <EndTime />
    <Description />
    <SortOrder>4</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Lords</House>
    <Category>Private Meeting</Category>
    <Location>Committee Room G</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='69'>
      <Description>Economic Affairs Committee</Description>
      <Inquiries />
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5549'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Closure of Michelin factory in Ballymena</Description>
    <SortOrder>5</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Adjournment</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4129'>
        <Name>Ian Paisley</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5751'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>16:30</StartTime>
    <EndTime>17:30</EndTime>
    <Description>Role and powers of the Groceries Code Adjudicator</Description>
    <SortOrder>5</SortOrder>
    <Type>Westminster Hall</Type>
    <House>Commons</House>
    <Category>Westminster Hall debate</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4079'>
        <Name>Julian Sturdy</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5806'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>10:00</StartTime>
    <EndTime />
    <Description>Will Richardson, Partner, PwC (Pricewaterhouse Coopers) 
Alastair Duke, Partner, PKF Littlejohn
Nick Brooks, Partner, Kingston Smith
Sue Berelowitz, former Deputy Children's Commissioner</Description>
    <SortOrder>5</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>The Wilson Room, Portcullis House</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='265'>
      <Description>Public Administration and Constitutional Affairs</Description>
      <Inquiries>
        <Inquiry Id='2313'>
          <Description>Kids Company</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5860'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Representations to French Authorities over Rob Lawrie case</Description>
    <SortOrder>5</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Oral questions</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags>
      <Tag>
        <Description>World</Description>
      </Tag>
    </Tags>
    <Members>
      <Member Id='738'>
        <Name>Lord Alton of Liverpool</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='6651'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>15:15</StartTime>
    <EndTime />
    <Description>(at 3:20 PM) 
Ms Ann Gross, Director responsible for policy on Special Needs, Children in Care, Adoption and children’s mental health, Department for Education
Ms Kate Copley, Deputy Director in the Education Funding Agency’s Academy Operations team, Department for Education
Ms Lesley Cox, Ofsted national lead for Special Educational Needs, Ofsted
Ms Claire Jackson, Legal team member, Independent Parental Special Educational Advice (IPSEA)
(at 4:20 PM) 
Ms Flora Goldhill, Director for Children, Families &amp; Communities, Department of Health
Mr John Holden, Director of Policy, Partnerships and Innovation, NHS England
Ms Sally Warren, Deputy Chief Inspector of Adult Social Care, Care Quality Commission</Description>
    <SortOrder>5</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Lords</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 4A, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='256'>
      <Description>Equality Act 2010 and Disability Committee</Description>
      <Inquiries>
        <Inquiry Id='2194'>
          <Description>Equality Act 2010 and Disability</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5853'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>10:00</StartTime>
    <EndTime />
    <Description>Andrew Bailey, Deputy Governor for Prudential Regulation and Chief Executive Officer of the Prudential Regulation Authority
David Belsham, External member, Prudential Regulation Authority Board
Mark Yallop, External member, Prudential Regulation Authority Board</Description>
    <SortOrder>6</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 8, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='54'>
      <Description>Treasury</Description>
      <Inquiries>
        <Inquiry Id='2481'>
          <Description>Prudential Regulation Authority Hearings: 2015-16</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5890'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>G20 and the Paris attacks</Description>
    <SortOrder>6</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Statement</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4205'>
        <Name>Baroness Stowell of Beeston</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='8078'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>15:15</StartTime>
    <EndTime />
    <Description>(at 3:30 PM) 
Mr Steve Holebrook, Director of Terrestrial Broadcast, Arqiva
Mr Anirban Roy, Director of Public Policy, Arqiva
(at 4:30 PM) 
The Rt Hon John Whittingdale OBE, MP, Secretary of State for Culture, Media and Sport, Department for Culture, Media and Sport</Description>
    <SortOrder>6</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Lords</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 2, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='64'>
      <Description>Communications Committee</Description>
      <Inquiries>
        <Inquiry Id='2199'>
          <Description>BBC Charter Renewal: public purposes and licence fee</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5564'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Welfare Reform and Work Bill - 2nd reading</Description>
    <SortOrder>7</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Legislation</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='3893'>
        <Name>Lord Freud</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata>
      <Metadata>
        <Url>http://services.parliament.uk/bills/2015-16/welfarereformandwork.html</Url>
        <Description>Bill webpage</Description>
      </Metadata>
    </Metadata>
  </Event>
  <Event Id='5704'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>10:15</StartTime>
    <EndTime />
    <Description>Nicholas Grisewood, Technical Specialist, Crisis Migration, International Labour Organisation
Rt Hon Desmond Swayne MP, Minister of State 
Matthew Wyatt, Deputy Director Middle East North Africa, Department for International Development 
Paul Morrison, Director of the UK Syrian resettlement programme, Home Office</Description>
    <SortOrder>7</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>The Grimond Room, Portcullis House</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='24'>
      <Description>International Development</Description>
      <Inquiries>
        <Inquiry Id='2357'>
          <Description>Syrian refugee crisis</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='6906'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>15:30</StartTime>
    <EndTime />
    <Description>(at 3:45 PM) 
Dr Chris Dolan, Director, Refugee Law Project, Uganda
Professor Doris Schopper, Director, Center for Education and Research in Humanitarian Action
Ms Josephine Wambui, Programme Officer Somalia, Oxfam Novib
(at 4:45 PM) 
Ms Niamh Hayes, Head of Office, Institute for International Criminal Investigations
Judge Mary McGowan Davie, former acting Justice, Supreme Court of New York
Ms Shana Swiss, Founder and Director, Women's Rights International</Description>
    <SortOrder>7</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Lords</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 1, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='259'>
      <Description>Sexual Violence in Conflict Committee</Description>
      <Inquiries>
        <Inquiry Id='2192'>
          <Description>Sexual Violence in Conflict</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5745'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>11:30</StartTime>
    <EndTime />
    <Description>Rt Hon Philip Hammond MP, Secretary of State
Vijay Rangarajan, Europe Director, Foreign and Commonwealth Office</Description>
    <SortOrder>8</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 15, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='18'>
      <Description>European Scrutiny</Description>
      <Inquiries>
        <Inquiry Id='2323'>
          <Description>UK Government's renegotiation of EU membership: parliamentary sovereignty and scrutiny</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5893'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>22:00</StartTime>
    <EndTime />
    <SortOrder>8</SortOrder>
    <Type>Main Chamber</Type>
    <House>Lords</House>
    <Category>Estimated rising time</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5808'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>11:30</StartTime>
    <EndTime />
    <Description>Professor Julian Lindley-French, Senior Fellow, Institute of Statecraft
Jonathan Parish, Deputy Assistant Secretary General for Defence Policy and Planning, NATO
General Sir Richard Shirreff KCB CBE, former Deputy Supreme Allied Commander Europe</Description>
    <SortOrder>9</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>The Thatcher Room, Portcullis House</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='9'>
      <Description>Defence</Description>
      <Inquiries>
        <Inquiry Id='2335'>
          <Description>Shifting the goalposts: Defence expenditure and the 2% pledge</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5788'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>14:00</StartTime>
    <EndTime />
    <Description>As for morning session, unless already heard.</Description>
    <SortOrder>10</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 5, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='233'>
      <Description>High Speed Rail (London-West Midlands) Bill</Description>
      <Inquiries>
        <Inquiry Id='1732'>
          <Description>High Speed Rail (London-West Midlands) Bill</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5600'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>14:00</StartTime>
    <EndTime />
    <Description>Pank Patel, Regional Schools Director, West Midlands, Department for Education
Lorna Fitzjohn, Regional Director, West Midlands, Ofsted
Ian Comfort, Chief Executive, Academies Enterprise Trust
Kirston Nelson, Director of Education, Libraries, and Adult Learning, Coventry City Council</Description>
    <SortOrder>11</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='14'>
      <Description>Education</Description>
      <Inquiries>
        <Inquiry Id='2250'>
          <Description>The Role of Regional Schools Commissioners</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5703'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>14:30</StartTime>
    <EndTime />
    <Description>Members of Parliament</Description>
    <SortOrder>12</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 8, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='2'>
      <Description>Backbench Business</Description>
      <Inquiries>
        <Inquiry Id='234'>
          <Description>Proposals for backbench debates</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5857'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>14:30</StartTime>
    <EndTime />
    <Description>Mark Keary, Principal, Bethnal Green Academy
Alison Brannick, former Deputy Head, Bethnal Green Academy
Sara Khan, Director, Inspire
Kalsoom Bashir, Director, Inspire
Dr Adnan Siddiqui, Director, CAGE Advocacy Ltd
Ibrahim Mohamoud, Communications Officer, CAGE Advocacy Ltd
Mohammed Umar Farooq </Description>
    <SortOrder>13</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>The Thatcher Room, Portcullis House</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='22'>
      <Description>Home Affairs</Description>
      <Inquiries>
        <Inquiry Id='2312'>
          <Description>Countering extremism</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5886'>
    <StartDate>2015-11-17T00:00:00</StartDate>
    <EndDate>2015-11-17T00:00:00</EndDate>
    <StartTime>14:30</StartTime>
    <EndTime />
    <Description>Chris Combemale, Chief Executive Officer, Direct Marketing Association
Professor Jonathan Montgomery, Chair, Nuffield Council on Bioethics
Renate Samson, Chief Executive, Big Brother Watch
Christopher Graham, Information Commissioner</Description>
    <SortOrder>14</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>The Wilson Room, Portcullis House</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='47'>
      <Description>Science and Technology</Description>
      <Inquiries>
        <Inquiry Id='2254'>
          <Description>Big data dilemma</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5543'>
    <StartDate>2015-11-16T00:00:00</StartDate>
    <EndDate>2015-11-16T00:00:00</EndDate>
    <StartTime>14:30</StartTime>
    <EndTime />
    <Description>Home Office, including Topical Questions</Description>
    <SortOrder>1</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Oral questions</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5792'>
    <StartDate>2015-11-16T00:00:00</StartDate>
    <EndDate>2015-11-16T00:00:00</EndDate>
    <StartTime>14:00</StartTime>
    <EndTime />
    <Description>The Board of Governors of Chiltern Way Federation School
Locus challenges</Description>
    <SortOrder>1</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 5, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='233'>
      <Description>High Speed Rail (London-West Midlands) Bill</Description>
      <Inquiries>
        <Inquiry Id='1732'>
          <Description>High Speed Rail (London-West Midlands) Bill</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5691'>
    <StartDate>2015-11-16T00:00:00</StartDate>
    <EndDate>2015-11-16T00:00:00</EndDate>
    <StartTime>16:00</StartTime>
    <EndTime />
    <Description>Councillor Keith House, Deputy Chair, Environment, Economy, Housing and Transport Board, Local Government Association
Councillor Lib Peck, Leader, London Borough of Lambeth Council
Stephen Hills, Director of Housing, South Cambridgeshire District Council
Councillor Ferris Cowper, Leader, East Hampshire District Council</Description>
    <SortOrder>2</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>The Thatcher Room, Portcullis House</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='6'>
      <Description>Housing, Communities and Local Government</Description>
      <Inquiries>
        <Inquiry Id='2262'>
          <Description>The Housing Association Sector and the Right to Buy</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5871'>
    <StartDate>2015-11-16T00:00:00</StartDate>
    <EndDate>2015-11-16T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Paris terrorist attacks </Description>
    <SortOrder>2</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Ministerial statement</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='8'>
        <Name>Mrs Theresa May</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5666'>
    <StartDate>2015-11-16T00:00:00</StartDate>
    <EndDate>2015-11-16T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>(i) Membership of the UK Delegation to the Parliamentary Assembly of the Council of Europe (ii) Famagusta</Description>
    <SortOrder>3</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Backbench Business</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5718'>
    <StartDate>2015-11-16T00:00:00</StartDate>
    <EndDate>2015-11-16T00:00:00</EndDate>
    <StartTime>16:00</StartTime>
    <EndTime />
    <Description>Dame Una O'Brien, Permanent Secretary, Department of Health
Simon Stevens, Chief Executive, NHS England
Jonathan Valabhji, National Clinical Director for Obesity and Diabetes, NHS England
Jonathan Marron, Director of Strategy, Public Health England</Description>
    <SortOrder>3</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>Room 15, Palace of Westminster</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='43'>
      <Description>Public Accounts</Description>
      <Inquiries>
        <Inquiry Id='2441'>
          <Description>Diabetes follow-up</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5680'>
    <StartDate>2015-11-16T00:00:00</StartDate>
    <EndDate>2015-11-16T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Transport for London Bill</Description>
    <SortOrder>4</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Opposed Private Business</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5785'>
    <StartDate>2015-11-16T00:00:00</StartDate>
    <EndDate>2015-11-16T00:00:00</EndDate>
    <StartTime>16:00</StartTime>
    <EndTime />
    <Description>Dame Rosemary Butler AM, Presiding Officer, National Assembly for Wales
Elisabeth Jones, Director of Legal Services, National Assembly for Wales
Adrian Crompton, Director of Assembly Business, National Assembly for Wales</Description>
    <SortOrder>4</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>The Grimond Room, Portcullis House</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='56'>
      <Description>Welsh Affairs</Description>
      <Inquiries>
        <Inquiry Id='2331'>
          <Description>Pre-legislative scrutiny of the draft Wales Bill</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
  <Event Id='5548'>
    <StartDate>2015-11-16T00:00:00</StartDate>
    <EndDate>2015-11-16T00:00:00</EndDate>
    <StartTime />
    <EndTime />
    <Description>Illicit arms trade in Africa</Description>
    <SortOrder>5</SortOrder>
    <Type>Main Chamber</Type>
    <House>Commons</House>
    <Category>Adjournment</Category>
    <HasSpeakers>false</HasSpeakers>
    <Committee xsi:nil='true' />
    <Tags />
    <Members>
      <Member Id='4054'>
        <Name>Stephen Phillips</Name>
        <SortOrder>1</SortOrder>
      </Member>
    </Members>
    <Metadata />
  </Event>
  <Event Id='5692'>
    <StartDate>2015-11-16T00:00:00</StartDate>
    <EndDate>2015-11-16T00:00:00</EndDate>
    <StartTime>16:10</StartTime>
    <EndTime />
    <Description>Robert Goodwill MP, Parliamentary Under-Secretary of State, Department for Transport
Sacha Hatteea, Deputy Director, Airport Capacity Delivery Division, Department for Transport</Description>
    <SortOrder>5</SortOrder>
    <Type>Select &amp; Joint Committees</Type>
    <House>Commons</House>
    <Category>Oral Evidence Session</Category>
    <Location>The Wilson Room, Portcullis House</Location>
    <HasSpeakers>false</HasSpeakers>
    <Committee Id='53'>
      <Description>Transport</Description>
      <Inquiries>
        <Inquiry Id='2352'>
          <Description>Surface transport to airports</Description>
          <SortOrder>1</SortOrder>
        </Inquiry>
      </Inquiries>
    </Committee>
    <Tags />
    <Members />
    <Metadata />
  </Event>
</ArrayOfEvent>
        ";
    }
}
