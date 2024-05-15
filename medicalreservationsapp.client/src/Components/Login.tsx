import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faUser } from "@fortawesome/free-solid-svg-icons";


function Login()
{
    return (
        <>
            <main className="flex items-center justify-center h-[95vh]">
                <form className="flex flex-col flex-wrap w-[210px] gap-[4px] ">
                    <FontAwesomeIcon className=" flex bg-blue-500 text-blue-200 ml-[20%]  p-[40px] mb-[40px] w-[50px] h-[50px] rounded-[30%] " icon={faUser} />
                    <label> Name:</label>
                    <input className=" h-[30px] rounded-[10px]  border-2  border-solid border-blue-500 border-solid bg-blue-500 text-white placeholder-white " type="text" placeholder="Name" />
                    <label>LastName:</label>
                    <input className=" h-[30px] rounded-[10px] border-2 border-blue-500 border-solid bg-blue-500 text-white placeholder-white " type="text" placeholder="LastName" />
               
                    <p className="mt-4 mb-0">Gender:</p>
                    <section className="flex flex-row mb-2">

                        <label className="flex  mr-[20px]">Male: <input className="w-[20px]" type="radio" name="gender" /> </label>

                        <label className="flex">Famale: <input className="w-[20px]" type="radio" name="gender" /> </label>
                        </section>
                    
                <label>Account:</label>
                    <input className=" h-[30px] rounded-[10px] border-2 border-blue-500 border-solid bg-blue-400 text-white placeholder-white " type="email" placeholder="Email" />
                <label>Password:</label>
                    <input className=" h-[30px] rounded-[10px] border-2 border-blue-500 border-solid bg-blue-500 text-white placeholder-white " type="password" placeholder="Password" />
                    <input className="h-10 mt-[20px] border-blue-500 border-solid bg-blue-500 rounded-[10px] text-white" type="submit" value="Register"></input>
            </form>
            </main>
        </>
    )

}

export default Login