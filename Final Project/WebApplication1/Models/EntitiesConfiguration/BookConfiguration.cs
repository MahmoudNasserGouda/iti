﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.EntitiesConfiguration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).UseIdentityColumn(1,1);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.PublishDate).IsRequired();
            builder.Property(p => p.Rating).IsRequired().HasDefaultValue(0).HasAnnotation("MinValue", 0).HasAnnotation("MaxValue", 100);
            builder.Property(p => p.AuthorName).IsRequired();
            builder.Property(p => p.ImagePath).IsRequired();
            builder.HasOne(p => p.Category).WithMany(p => p.Books).HasForeignKey(p => p.CategoryId);
            builder.HasMany(p => p.Users).WithMany(p => p.Books);
            builder.HasMany(p => p.OwnerUsers).WithMany(p => p.OwnedBooks);
            builder.HasMany(p => p.Chapters).WithOne(p => p.Book).HasForeignKey(p => p.BookID).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.Reviews).WithOne(p => p.Book).HasForeignKey(p => p.BookID).OnDelete(DeleteBehavior.Cascade);
            builder.HasData(new List<Book>() { 
                new Book(){
                    ID=1,
                    Name= "The Call of Cthulhu",
                    Description= "The Call of Cthulhu is a short story by American writer H. P. Lovecraft. Written in the summer of 1926, it was first published in the pulp magazine Weird Tales in February 1928.",
                    AuthorName= "H. P. Lovecraft",
                    Rating=70,
                    PublishDate= "1928",
                    ImagePath= "https://m.media-amazon.com/images/I/515TltJSPEL.jpg", 
                    Price= 19.99, 
                    CategoryId=1 
                },
                new Book(){
                    ID=2, 
                    Name = "The Monkey's Paw", 
                    Description = "The Monkey's Paw is a short story by English writer W.W. Jacobs. It was first published in Harper's Monthly magazine in 1902. The story follows the White family, who come into possession of a magical monkey's paw that grants three wishes.",
                    AuthorName = "W.W. Jacobs",
                    Rating = 0,
                    PublishDate = "1902", 
                    Price = 9.99, 
                    ImagePath="https://m.media-amazon.com/images/I/51e7aoodRtL.jpg", 
                    CategoryId=1
                }, 
                new Book(){
                    ID=3,
                    Name = "The Tell-Tale Heart",
                    Description = "The Tell-Tale Heart is a short story by American writer Edgar Allan Poe. It was first published in 1843. The story is narrated by an unnamed protagonist who is obsessed with the eye of an elderly man. As his obsession grows, he commits a heinous act of murder.",
                    AuthorName = "Edgar Allan Poe",
                    Rating = 0,
                    PublishDate = "1843",
                    Price = 14.99, 
                    CategoryId=1, 
                    ImagePath="https://m.media-amazon.com/images/I/71igzz1F+JL._AC_UF1000,1000_QL80_.jpg"
                }, 
                new Book(){
                    ID=4,
                    Name = "Carmilla", 
                    Description = "Carmilla is a Gothic novella by Irish writer J. Sheridan Le Fanu. It was first published in 1872. The story revolves around a young woman named Laura, who becomes friends with the mysterious and alluring Carmilla. As their relationship deepens, Laura begins to suspect that Carmilla may be a supernatural entity.",
                    AuthorName = "J. Sheridan Le Fanu",
                    Rating = 40,
                    PublishDate = "1872",
                    Price = 12.99, 
                    CategoryId=1, 
                    ImagePath="https://images.penguinrandomhouse.com/cover/9781782275848"
                },
                new Book(){
                    ID=5,
                    Name = "The Yellow Wallpaper",
                    Description = "The Yellow Wallpaper is a haunting short story by American writer Charlotte Perkins Gilman. It was first published in 1892. The story is narrated by a woman who is confined to a room with yellow wallpaper. As her mental state deteriorates, she becomes obsessed with the wallpaper, leading to a descent into madness.",
                    AuthorName = "Charlotte Perkins Gilman",
                    Rating = 0,
                    PublishDate = "1892",
                    Price = 11.99, 
                    CategoryId=1, 
                    ImagePath="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSpjWuHwCM_LBBK08M-ZsGGZ6hOm6pBxrngYEzRTTJ&s"
                },
				new Book()
				{
					ID=6,
					Name = "The Lottery",
					Description = "\"The Lottery\" is a short story written by Shirley Jackson, first published in The New Yorker in 1948. The story takes place in a small village where the residents gather every year for a traditional lottery. The lottery is conducted by Mr. Summers, who is assisted by Mr. Graves. The lottery is an important event in the village, and everyone is expected to participate.",
					AuthorName = "Shirley Jackson",
					Rating = 20,
					PublishDate = "1948",
					Price = 18.99,
					CategoryId=1,
					ImagePath="https://m.media-amazon.com/images/I/41UeFk25KpL._SY264_BO1,204,203,200_QL40_ML2_.jpg"

				} ,
				new Book()
				{
					ID=7,
					Name = "The Masque of the Red Death",
					Description = " The Masque of the Red Death is a short story written by Edgar Allan Poe that was first published in 1842. The story takes place in an unnamed kingdom that is being ravaged by a deadly plague known as the \"Red Death.\" The disease is highly contagious and kills its victims within half an hour of infection, causing them to bleed from their pores and suffer from sharp pains and dizziness.",
					AuthorName = "Edgar Allan Poe",
					Rating = 0,
					PublishDate = "1842",
					Price = 23.99,
					CategoryId=1,
					ImagePath="https://cdn.kobo.com/book-images/ba02330e-f309-403c-919f-cf0d7ddb697c/353/569/90/False/the-masque-of-the-red-death-65.jpg"
				} ,
				new Book()
				{
					ID=8,
					Name = "The Cask of Amontillado",
					Description = "\"The Cask of Amontillado\" is a short story written by Edgar Allan Poe, first published in 1846. The story is set in Italy and follows the narrator, Montresor, as he seeks revenge against his perceived enemy, Fortunato.",
					AuthorName = "Edgar Allan Poe",
					Rating = 0,
					PublishDate = "1846",
					Price = 20.99,
					CategoryId=1,
					ImagePath="https://cdn.kobo.com/book-images/f446f806-8fb5-4a90-a30d-d90a4fb0a6ec/353/569/90/False/the-cask-of-amontillado-61.jpg"
				} ,
				new Book()
				{
					ID=9,
					Name = "The Signal-Man",
					Description = "\"The Signal-Man\" is a short story by Charles Dickens, first published in 1866. It tells the eerie and suspenseful tale of a lonely signalman who works at a railway station and his encounters with a mysterious specter who appears to him repeatedly.",
					AuthorName = "Charles Dickens",
					Rating = 0,
					PublishDate = "1866",
					Price = 27.99,
					CategoryId=1,
					ImagePath="https://m.media-amazon.com/images/I/51-BGOvFQFL._SY425_.jpg"
				}
				,
				new Book()
				{
					ID=10,
					Name = "The Black Cat",
					Description = " The Black Cat is a short story by Edgar Allan Poe, first published in 1843. It is a chilling tale of a man's descent into madness, murder, and guilt. The story is narrated by an unnamed protagonist who, at the beginning of the story, is a happy and loving husband and pet owner. However, he becomes increasingly violent and cruel to his wife and pets as he becomes more and more consumed by alcoholism and his own inner demons.",
					AuthorName = "Edgar Allan Poe",
					Rating = 0,
					PublishDate = "1843",
					Price = 20.99,
					CategoryId=1,
					ImagePath="https://cdn.kobo.com/book-images/5b09b3db-1931-4117-adf8-f84dd972ce49/353/569/90/False/the-black-cat-illustrated.jpg"
				},
				new Book()
				{
					ID = 11,
					Name = "The Letter",
					Description = "From Capri to Timbuktu the adventure picks up where The Ring leaves off. With the discovery of an ancient parchment. Buried for some two thousand years in some far away desolate land. The final words of a condemned man. Beseeching reconciliation between Jews and Gentiles. A Cardinal intent on returning it to the Church. And relic collectors intent of possessing it. ",
					AuthorName = "Bradley Pearce",
					Rating = 0,
					PublishDate = "2013",
					Price = 11.99,
					CategoryId = 2,
					ImagePath = "https://www.obooko.com/images-cache/the-letter-bradley-pearce-obooko-e90ac0c30545faee91828ebbd2aff2d9.jpg"
				}, 
                new Book()
				{
					ID = 12,
					Name = "The Gilgamesh Project Book V Cuba ",
					Description = "Arkady Demitriev had been a young boy when the Soviet Union had been dissolved by Mikhail Gorbachev and had just enrolled as a student at Moscow State University when Vladimir Putin was elected president of the Russian Federation.",
					AuthorName = "John Francis Kinsella",
					Rating = 0,
					PublishDate = "2017",
					Price = 11.99,
					CategoryId = 2,
					ImagePath = "https://m.media-amazon.com/images/I/71VKvAHWPsL._AC_UF1000,1000_QL80_.jpg"
				}, 
                new Book()
				{
					ID = 13,
					Name = "Keyhole Island ",
					Description = "It was listed as an endurance trip for only the most experienced and physically fit young men and women between the ages of 21 and 28 who had experience in endurance sports such as mountain climbing, caving, racing, survival living, skiing and motor cycling. Its itinerary included a learning cruise for those who never sailed on a two-masted, square topsail schooner from San Francisco to Australia and then an endurance hike across the Outback to the western coast. The journey would include the Anyang.",
					AuthorName = "Charles Coiro",
					Rating = 0,
					PublishDate = "2013",
					Price = 11.99,
					CategoryId = 2,
					ImagePath = "https://m.media-amazon.com/images/I/41TSQC8khCL._SX260_.jpg"
				}, 
                new Book()
				{
					ID = 14,
					Name = "House Of Refuge ",
					Description = "Justin Agnarsson is stationkeeper and lone crewman of South Atlantic House of Refuge #49, a floating sanctuary for the thousands of mariners and seasteading families who live and work in the 350-mile long Plata Raft. Now, war threatens to bring an end to his lifesaving mission as an Argentine warship pursues a pair of refugees to the station. A house of refuge is supposed to be inviolable, but the Argentines are hell-bent on their mission. Alone and virtually defenseless, Agnarsson faces an impossible choice between duty and survival. But when the brutality of war threatens to unravel the fabric of civilization, more than lives are at stake.",
					AuthorName = "Michael DiBaggio",
					Rating = 0,
					PublishDate = "2018",
					Price = 11.99,
					CategoryId = 2,
					ImagePath = "https://m.media-amazon.com/images/I/61SMBiRkspL._AC_UF1000,1000_QL80_.jpg"

				},
				new Book()
				{
					ID = 15,
					Name = "Planning Armageddon",
					Description = "A radical reinterpretation of the nature and significance of the relationship between economics and sea power before and during the First World War. It focuses on Great Britain's development of a novel and highly sophisticated approach to economic coercion in the event of war against Germany.",
					AuthorName = "George McNeur",
					Rating = 0,
					PublishDate = "2019",
					Price = 11.99,
					CategoryId = 2,
					ImagePath = "https://m.media-amazon.com/images/I/51hL-euOygL.jpg"

				},
				new Book()
				{
				    ID = 16,
				    Name = "Short Fuses",
				    Description = "From one of the most successful thriller writers in the United Kingdom, Stephen Leather: a compilation of more exciting stories to complement his first book in the series 'Short Fuses.' which is also available for free download from obooko.com. The author has also included the opening chapters of five of his bestselling thrillers to give you a taste of what's to come!",
				    AuthorName = "Stephen Leather",
				    Rating = 0,
				    PublishDate = "2014",
				    Price = 11.99,
				    CategoryId = 2,
				    ImagePath = "https://images-eu.ssl-images-amazon.com/images/I/91mPmGRtKmL._AC_UL600_SR600,600_.jpg"
				},
                new Book(){
                ID = 17,
                Name = "The Science Fiction Hall of Fame Volume",
                Description = "The Science Fiction Hall of Fame, Volume 2A\" is a book containing a collection of classic short science fiction stories selected for induction into the Science Fiction Hall of Fame.",
                AuthorName = "Ben Bova",
                Rating = 0,
                PublishDate = "1973",
                Price = 9.99,
                ImagePath="https://m.media-amazon.com/images/I/81lGDr2Ib5L._AC_UF1000,1000_QL80_.jpg",
                CategoryId=3
                },
                new Book(){
                    ID = 18,
                    Name = "The Science Fiction Megapack",
                    Description = "The Science Fiction Megapack is an anthology of science fiction stories edited by Ben Bova and James Patrick Kelly. The book features a wide range of science fiction stories from classic authors such as H.G. Wells",
                    AuthorName = "Ben Bova James Blish Robert Silverberg",
                    Rating = 0,
                    PublishDate = "1994",
                    Price = 11.99,
                    ImagePath="https://www.booksfree.org/wp-content/uploads/2022/09/The-Science-Fiction-Megapack-by-Ben-Bova-James-Blish-Robert-Silverberg-pdf-free-download.jpg",
                    CategoryId=3
                },
                new Book(){
                    ID = 19,
                    Name = "The Vector",
                    Description =  "It's the age of the home-made virus, and humanity is dying. It just doesn't know it yet. In Prague, a young woman named Eva returns home to escape the plagues, only to find her mother missing and the police blaming her for the worst outbreaks in recent memory. Events are complicated by the appearance of a Healer - a merciless Chinese agent - sent to neutralize a new strain that may bring Prague to its knees. With only days until the launch of a super-virus, Eva must navigate a hostile city and escape to safety before she becomes another faceless victim in this global.",
                    AuthorName = "MCM",
                    Rating = 0,
                    PublishDate = "1940",
                    Price = 11.99,
                    ImagePath="https://www.obooko.com/images-cache/vector-scifi-horror-thriller-obooko-5a9b6745e9c49f6d9e3d0c11b8af3a87.jpg",
                    CategoryId=3
                },
                new Book(){
                    ID = 20,
                    Name = " Back to Work: The Caldar Chronicles Book Four",
                    Description =  "“GODS, NO! No wishes! Nothing good EVER comes of it! And if I ever find out why, SOMETHING is gonna DIE!” His new ship finally ready, Rondal Caldar begins his task in earnest - resolving the Drecks issue. First, though, he must ferret out more information about their society.To help him out, he's brought along a helper this time - the ex-mercenary companion known as “Four.”",
                    AuthorName = "Floyde Leong",
                    Rating = 0,
                    PublishDate = "1990",
                    Price = 15.99,
                    ImagePath="https://www.obooko.com/images-cache/back-to-work-c749bae1b41fe45b9f421ec5cf968f79.jpg",
                    CategoryId=3
                },
                new Book(){
                    ID = 21,
                    Name = "Picking Up The Pieces",
                    Description =  "note: this is an Adult-themed, Science Fiction Space Opera intended for readers over the age of 17.“Boss…” Laisee whispered, and turned from Wilber to confront Donald. “You told him?”“He’s seen me naked,” he mumbled, then shrugged his shoulders slightly..",
                    AuthorName = "Floyde Leong",
                    Rating = 0,
                    PublishDate = "2001",
                    Price = 14.99,
                    ImagePath="https://www.obooko.com/images-cache/picking-up-the-pieces-cd8ca5928bdf2376583476a6c203a463.jpg",
                    CategoryId=3
                },
                new Book(){
                    ID = 22,
                    Name = " Man in the Moon",
                    Description =  "Tom stumbles upon a discovery that challenged everything he had ever read about the Roswell crash in Forty-Seven. A satellite that cannot be allowed to go into orbit. Cradling a homing beacon that would signal a fleet of unwelcomed visitors to the fragile blue marble floating in the vastness of space, Earth. Home to eight billion unsuspecting casualties. Can Tom prevent the launch? Can the old man put an end to what his father had started? Putting an end to the hideous creature Sirius and the clandestine moon base, Trinity...",
                    AuthorName = "Bradley Pearce",
                    Rating = 0,
                    PublishDate = "2005",
                    Price = 31.99,
                    ImagePath="https://www.obooko.com/images-cache/man-in-the-moon-cover-obooko-b994d4f2dc76ae00eae8fa10a6b30096.jpg",
                    CategoryId=3
                },
                new Book(){
                    ID = 23,
                    Name = "The Ware Tetralogy",
                    Description =  "It starts with Software, where rebel robots bring immortality to their human creator by eating his brain. Software won the first Philip K. Dick Award.In Wetware, the robots decide to start building people—and people get strung out on an insane new drug called merge. This cyberpunk classic garnered a second Philip K. Dick award.By Freeware, the robots have evolved into soft plastic slugs called moldies­—and some human “cheeseballs” want to have sex with them. The action redoubles when aliens begin arriving in the form of cosmic rays.",
                    AuthorName = " Rudy Rucker",
                    Rating = 0,
                    PublishDate = "2010",
                    Price = 5.99,
                    ImagePath="https://www.obooko.com/images/covers/ware-tetralogy-rucker.jpg",
                    CategoryId=3
                },
                new Book(){
                    ID = 24,
                    Name = "The Fall of the Gods",
                    Description =  "When new graduate Yuki Kashizawa moves to London for her PhD, she is certainly not expecting to be dragged into a mystery. At the Deverex Tower, an ultra-modern skyscraper and her new home, Yuki bumps into the extravagant Rupert Howards. He involves her in his personal investigation on the building’s former owner, Edwin Deverex, a brilliant scientist who vanished into thin air years before.",
                    AuthorName = "Nicola Bagalà",
                    Rating = 0,
                    PublishDate = "2000",
                    Price = 31.99,
                    ImagePath="https://www.obooko.com/images/covers/the-fall-of-the-gods-obooko.jpg",
                    CategoryId=3
                },
                new Book(){
                    ID = 25,
                    Name = "Homeland",
                    Description =  "In Cory Doctorow’s wildly successful Little Brother, young Marcus Yallow was arbitrarily detained and brutalized by the government in the wake of a terrorist attack on San Francisco—an experience that led him to become a leader of the whole movement of technologically clued-in teenagers, fighting back against the tyrannical security state.A few years after a terrorist attack on San Francisco, California’s economy collapses. But Marcus Yarrow's hacktivist past lands him a job as webmaster for a crusading politician who promises reform.  ",
                    AuthorName = "Cory Doctorow",
                    Rating = 0,
                    PublishDate = "2013",
                    Price = 31.99,
                    ImagePath="https://www.obooko.com/images/covers/homeland.jpeg",
                    CategoryId=3
                },
                new Book(){
                    ID = 26,
                    Name = "Elis Royd",
                    Description =  "Ellis Asteroid is Earth's long-abandoned naturalization station for extraterrestrial refugees - her bounteous hub walled off by arrogant human administrators, her ignorant non-human population left to rot in the wilds.Bursting with backstabbers, man-eating cockroaches, and bloodsucking maters, Elis Royd is a fascinating sci-fi adventure from a master storyteller. For thinking readers only.Excerpt:Beppo took his time on the final grade.",
                    AuthorName = "Ron Sanders",
                    Rating = 0,
                    PublishDate = "2004",
                    Price = 31.99,
                    ImagePath="https://www.obooko.com/images/covers/science-fiction-books-elis-royd-ron-sanders.jpg",
                    CategoryId=3
                }
			});




        }
    }
}
